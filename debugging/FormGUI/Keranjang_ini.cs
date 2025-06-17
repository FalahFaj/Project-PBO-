using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using debugging.Assets;
using debugging.Model;
using debugging.Service;
using debugging.PenghubungDB;

namespace debugging.FormGUI
{
    public partial class Keranjang_ini : Form
    {
        private UserLogin akun;
        private ServiceAkun serviceAkun;

        public Keranjang_ini(UserLogin userLogin, ServiceAkun serviceAkun) 
        {
            InitializeComponent();
            this.akun = userLogin;
            this.serviceAkun = serviceAkun; 
            this.Load += Keranjang_Load;
        }

        private void Keranjang_ini_Load(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
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
                            FotoProduk = !string.IsNullOrEmpty(produk.foto) && System.IO.File.Exists(produk.foto) ? Image.FromFile((produk.foto)) : FotoDefault.GetFotoDefault(),
                            JumlahProduk = detail.jumlah
                        };

                        flpProduk_keranjang.Controls.Add(kartu);
                    }
                }
            }
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pembayaran pembayaran = new Pembayaran(serviceAkun, akun);
            pembayaran.ShowDialog();
            this.Hide();
        }
    }
}
