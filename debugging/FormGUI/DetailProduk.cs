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

        private Image FotoProduk(byte[] byteFoto)
        {
            if (byteFoto != null && byteFoto.Length > 0)
            {
                using (var ms = new MemoryStream(byteFoto))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Anda telah membeli produk {produk.nama} seharga Rp {produk.harga:N0}.");
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Produk {produk.nama} telah ditambahkan ke keranjang.");
        }
    }
}
