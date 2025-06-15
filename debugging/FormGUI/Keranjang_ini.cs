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
using debugging.PenghubungDB;

namespace debugging.FormGUI
{
    public partial class Keranjang_ini : Form
    {
        private UserLogin akun;
        public Keranjang_ini(UserLogin userLogin)
        {
            InitializeComponent();
            this.akun = userLogin;
        }
        private void Keranjang_Load(object sender, EventArgs e)
        {
            LoadKeranjang();
        }
        private void LoadKeranjang()
        {
            flpProduk_keranjang.Controls.Clear();
            using (var db = new KoneksiDB())
            {
                var keranjang = db.keranjang.FirstOrDefault(k => k.id_customer == akun.Id);
                if (keranjang == null)
                {
                    MessageBox.Show("Keranjang kosong");
                    return;
                }
                var detailKeranjang = db.detail_keranjang
                    .Where(dk => dk.id_keranjang == keranjang.id_keranjang)
                    .ToList();
                foreach (var detail in detailKeranjang)
                {
                    var produk = db.produk.FirstOrDefault(p => p.id_produk == detail.id_produk);
                    if (produk != null)
                    {
                        var kartu = new Produk_di_Keranjang
                        {
                            NamaProduk = produk.nama,
                            HargaProduk = produk.harga,
                            FotoProduk = produk.foto != null ? Image.FromStream(new System.IO.MemoryStream(produk.foto)) : null,
                            JumlahProduk = detail.jumlah
                        };

                        flpProduk_keranjang.Controls.Add(kartu);
                    }
                }
            }
        }
    }
}
