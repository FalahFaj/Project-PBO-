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
        private decimal totalSewa;
        public Form_Penyewaan(Produk produk, UserLogin userLogin, ServiceAkun serviceAkun)
        {
            InitializeComponent();
            this.produk = produk;
            this.akun = userLogin;
            this.serviceAkun = serviceAkun;
            this.Load += Penyewaan_Load;
            numericUpDownJumlah.ValueChanged += numericUpDownJumlah_ValueChanged;
        }


        public void Penyewaan_Load(object sender, EventArgs e)
        {
            decimal dp = produk.harga / 2;
            lblProduk.Text = produk.nama;
            lblDp.Text = $"Rp {dp:N0}";
            numericUpDownJumlah.Minimum = 1;
            numericUpDownJumlah.Maximum = produk.stok;

            using (var db = new KoneksiDB())
            {
                metodePembayaran = db.metode_pembayaran.ToList();
                var customer = db.customer.FirstOrDefault(c => c.id_customer == akun.Id);
                if (customer != null)
                {
                    if (customer.rt == null && customer.rw == null && customer.kelurahan == null && customer.kecamatan == null && customer.kota == null)
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
                }
            }
            comboBox1.Items.Clear();
            foreach (var metode in metodePembayaran)
            {
                comboBox1.Items.Add(metode.metode_pembayaran);
            }
            HitungTotalSewa();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (tanggalSewa.Value >= tanggalKembali.Value)
                tanggalKembali.Value = tanggalSewa.Value.AddDays(1);
            HitungTotalSewa();
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (tanggalKembali.Value <= tanggalSewa.Value)
                tanggalKembali.Value = tanggalSewa.Value.AddDays(1);
            HitungTotalSewa();
        }
        private void numericUpDownJumlah_ValueChanged(object sender, EventArgs e)
        {
            HitungTotalSewa();
        }
        private void HitungTotalSewa()
        {
            int jumlah = (int)numericUpDownJumlah.Value;
            decimal dp = produk.harga / 2;
            decimal total = dp * jumlah;
            lblDp.Text = $"Rp {total:N0}";
            totalSewa = total;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var metode = metodePembayaran.FirstOrDefault(m => m.metode_pembayaran == comboBox1.SelectedItem.ToString());
                if (metode != null)
                {
                    lblNoRek.Text = metode.no_rekening;
                }
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
                MessageBox.Show("Alamat Anda belum lengkap. Silakan lengkapi alamat terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            int jumlah = (int)numericUpDownJumlah.Value;
            int hariSewa = (tanggalKembali.Value - tanggalSewa.Value).Days;
            var metode = metodePembayaran.FirstOrDefault(m => m.metode_pembayaran == comboBox1.SelectedItem.ToString());
            if (metode == null)
            {
                MessageBox.Show("Metode pembayaran tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var db = new KoneksiDB())
            {
                try
                {
                    var penyewaan = new Penyewaan
                    {
                        tanggal_sewa = DateTime.SpecifyKind(tanggalSewa.Value, DateTimeKind.Utc),
                        tanggal_kembali = DateTime.SpecifyKind(tanggalKembali.Value, DateTimeKind.Utc),
                        pembayaran_dp = totalSewa / 2,
                        status_dp = "Belum Dibayar",
                        status_peminjaman = "Menunggu Konfirmasi",
                        id_customer = akun.Id
                    };
                    db.penyewaan.Add(penyewaan);
                    db.SaveChanges();
                    var item_penyewaan = new Item_penyewaan
                    {
                        id_penyewaan = penyewaan.id_penyewaan,
                        id_produk = produk.id_produk,
                        jumlah = jumlah,
                        harga = totalSewa,
                        durasi_hari = hariSewa
                    };
                    db.item_penyewaan.Add(item_penyewaan);
                    db.SaveChanges();
                    var transaksi = new Transaksi
                    {
                        tanggal = DateTime.UtcNow,
                        nominal = totalSewa / 2,
                        id_customer = akun.Id,
                        id_metode_pembayaran = metode.id_metode_pembayaran,
                        id_penyewaan = penyewaan.id_penyewaan,
                        id_jenis_transaksi = 2 
                    };
                    db.transaksi.Add(transaksi);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    string errorMsg = $"Terjadi kesalahan saat menyimpan data: {ex.Message}";
                    if (ex.InnerException != null)
                    {
                        errorMsg += $"\nDetail: {ex.InnerException.Message}";
                    }
                    MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("Penyewaan berhasil dibuat. Silakan tunggu konfirmasi dari admin.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Penyewaan_Load(object sender, EventArgs e)
        {

        }
    }
}
