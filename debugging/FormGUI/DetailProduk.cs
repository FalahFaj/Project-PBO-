using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using debugging.Model;
using debugging.Service;
using System.IO;
using debugging.Assets;
using System.Reflection;
using debugging.PenghubungDB;

namespace debugging.FormGUI
{
    public partial class DetailProduk : Form
    {
        private Produk produk;
        private UserLogin akun;
        private ServiceAkun serviceAkun;
        public DetailProduk(Produk produk, UserLogin akun, ServiceAkun serviceAkun)
        {
            InitializeComponent();
            this.produk = produk;
            this.akun = akun;
            this.serviceAkun = serviceAkun;

            pictureBox1.Image = FotoProduk(produk.foto);
            label1.Text = produk.nama;
            label2.Text = $"Rp {produk.harga:N0}";
            label3.Text = produk.GetType().GetProperty("deskripsi") != null ?
                (string)produk.GetType().GetProperty("deskripsi").GetValue(produk) :
                "Deskripsi belum tersedia";

            numericUpDownJumlah.Enabled = true;
            numericUpDownJumlah.Maximum = produk.stok;
        }

        private Image FotoProduk(string filePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                {
                    return Image.FromFile(filePath);
                }
                else
                {
                    return Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("debugging.Assets.FotoDefault.png"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat gambar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (produk.disewakan)
            {
                int jumlah = (int)numericUpDownJumlah.Value;
                Form_Penyewaan penyewaan = new Form_Penyewaan(produk, akun, serviceAkun, jumlah);
                penyewaan.ShowDialog();
            }
            else
            {
                int jumlah = (int)numericUpDownJumlah.Value;
                Pembayaran pembayaran = new Pembayaran(produk, serviceAkun, akun, jumlah);
                pembayaran.ShowDialog();
            }
            this.Show();
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            int jumlah = (int)numericUpDownJumlah.Value;
            string error;
            if (jumlah <= 0)
            {
                bool sukses = ServiceKeranjang.TambahKeranjang(akun.Id, produk.id_produk, jumlah, out error);
                if (sukses)
                {
                    MessageBox.Show("Produk berhasil ditambahkan ke keranjang", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Jumlah produk harus lebih dari 0", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
