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
                btnBeli.Text = "Sewa";
                Form_Penyewaan penyewaan = new Form_Penyewaan(produk, akun, serviceAkun);
                penyewaan.ShowDialog();
            }
            else
            {
                Pembayaran pembayaran = new Pembayaran(produk, serviceAkun, akun);
                pembayaran.ShowDialog();
            }
            this.Show();
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            using (var db = new KoneksiDB())
            {
                var keranjang = db.keranjang.FirstOrDefault(k => k.id_customer == akun.Id);
                if (keranjang == null)
                {
                    keranjang = new Keranjang
                    {
                        id_customer = akun.Id,
                    };
                    db.keranjang.Add(keranjang);
                    db.SaveChanges();
                }
                var detailKeranjang = db.detail_keranjang.FirstOrDefault(dk => dk.id_produk == produk.id_produk && dk.id_keranjang == keranjang.id_keranjang);
                if (detailKeranjang != null)
                {
                    detailKeranjang.jumlah += 1;
                }
                else
                {
                    detailKeranjang = new Detail_keranjang
                    {
                        id_produk = produk.id_produk,
                        id_keranjang = keranjang.id_keranjang,
                        jumlah = 1
                    };
                    db.detail_keranjang.Add(detailKeranjang);
                }
                db.SaveChanges();
            }
            MessageBox.Show("Produk telah ditambahkan ke keranjang.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
