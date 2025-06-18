using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using debugging.Model;
using debugging.Service;
using debugging.Model;
using Project_PBO_Kel_5.Model;
using debugging.PenghubungDB;

namespace debugging
{
    public partial class Form_Penyewaan : Form
    {
        private Produk produk;
        private UserLogin akun;
        private ServiceAkun serviceAkun;
        private List<Metode_pembayaran> metodePembayaran;
        private PenyewaanService penyewaanService;
        private decimal totalSewa;
        public Form_Penyewaan(Produk produk, UserLogin userLogin, ServiceAkun serviceAkun)
        {
            InitializeComponent();
            this.produk = produk;
            this.akun = userLogin;
            this.serviceAkun = serviceAkun;
            penyewaanService = new PenyewaanService(akun, produk);

            this.Load += Penyewaan_Load;
            numericUpDownJumlah.ValueChanged += numericUpDownJumlah_ValueChanged;
            tanggalSewa.ValueChanged += dateTimePicker1_ValueChanged;
            tanggalKembali.ValueChanged += dateTimePicker2_ValueChanged;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            btnSewa.Click += btnSewa_Click;
            btnKembali.Click += btnKembali_Click;
        }

        public void Penyewaan_Load(object sender, EventArgs e)
        {
            Load_Data_Penyewaan();
        }
        private void HitungTotalSewa()
        {
            int jumlah = (int)numericUpDownJumlah.Value;
            decimal dp = produk.harga / 2;
            decimal total = dp * jumlah;
            lblDp.Text = $"Rp {total:N0}";
            totalSewa = total;
        }
        private void Load_Data_Penyewaan()
        {
            lblProduk.Text = produk.nama;
            numericUpDownJumlah.Minimum = 1;
            numericUpDownJumlah.Maximum = produk.stok;

            var customer = penyewaanService.GetCustomerData();
            if (customer == null || !penyewaanService.ValidateAlamat(customer))
            {
                lblAlamat.Text = "Alamat tidak tersedia";
                var regis = MessageBox.Show(
                    "Alamat Anda belum lengkap. Apakah Anda ingin mengisi alamat sekarang?",
                    "Informasi Alamat",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (regis == DialogResult.Yes)
                {
                    this.Hide();
                    Regist_Alamat alamatForm = new Regist_Alamat(akun);
                    alamatForm.ShowDialog();
                    this.BeginInvoke(new Action(() => this.Close()));
                }
                else
                {
                    this.BeginInvoke(new Action(() => this.Close()));
                }
            }
            else
            {
                lblAlamat.Text = $"{customer.rt}, {customer.rw}, {customer.kelurahan}, {customer.kecamatan}, {customer.kota}, {customer.provinsi}";
            }
            metodePembayaran = penyewaanService.GetMetodePembayaran();
            comboBox1.Items.Clear();
            foreach (var metode in metodePembayaran)
            {
                comboBox1.Items.Add(metode.metode_pembayaran);
            }
            HitungTotalSewa();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) =>
            AdjustReturnDate();
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) =>
            AdjustReturnDate();
        private void AdjustReturnDate()
        {
            if (tanggalSewa.Value >= tanggalKembali.Value)
                tanggalKembali.Value = tanggalSewa.Value.AddDays(1);
            HitungTotalSewa();
        }
        private void numericUpDownJumlah_ValueChanged(object sender, EventArgs e) =>
            HitungTotalSewa();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var metode = metodePembayaran.FirstOrDefault(m => m.metode_pembayaran == comboBox1.SelectedItem.ToString());
                if (metode != null)
                    lblNoRek.Text = metode.no_rekening;
            }
            else
            {
                lblNoRek.Text = "-";
            }
        }
        private void btnSewa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblAlamat.Text))
            {
                MessageBox.Show("Alamat Anda belum lengkap.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih metode pembayaran.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tanggalSewa.Value >= tanggalKembali.Value)
            {
                MessageBox.Show("Tanggal kembali harus setelah tanggal sewa.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numericUpDownJumlah.Value <= 0)
            {
                MessageBox.Show("Jumlah barang disewa tidak boleh kurang dari 1.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string errorMessage;
            penyewaanService.SimpanPenyewaan(
                tanggalSewa.Value,
                tanggalKembali.Value,
                (int)numericUpDownJumlah.Value,
                comboBox1.SelectedItem.ToString(),
                out errorMessage);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show(
                "Penyewaan berhasil dibuat. Apakah Anda ingin melanjutkan ke cetak struk?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Cetak_Struk.BuatStrukPenyewaan(
                    akun.Name,
                    produk.nama,
                    (int)numericUpDownJumlah.Value,
                    totalSewa,
                    tanggalSewa.Value,
                    tanggalKembali.Value,
                    comboBox1.SelectedItem.ToString(),
                    metodePembayaran.FirstOrDefault(m => m.metode_pembayaran == comboBox1.SelectedItem.ToString())?.no_rekening,
                    lblAlamat.Text);
            }
            MessageBox.Show("Penyewaan berhasil dibuat. Silakan tunggu konfirmasi dari admin.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void btnKembali_Click(object sender, EventArgs e) => this.Close();
    }
}