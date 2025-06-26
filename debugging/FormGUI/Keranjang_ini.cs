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
                            IdProduk = produk.id_produk,
                            NamaProduk = produk.nama,
                            HargaProduk = produk.harga,
                            FotoProduk = !string.IsNullOrEmpty(produk.foto) && System.IO.File.Exists(produk.foto) ? Image.FromFile((produk.foto)) : FotoDefault.GetFotoDefault(),
                            JumlahProduk = detail.jumlah
                        };
                        kartu.CheckboxChanged += ProdukCheckboxChanged;
                        flpProduk_keranjang.Controls.Add(kartu);
                    }
                }
            }
            UpdateBtnBeliState();
        }
        private void ProdukCheckboxChanged(object sender, EventArgs e)
        {
            UpdateBtnBeliState();
        }

        private void UpdateBtnBeliState()
        {
            btnBeli.Enabled = flpProduk_keranjang.Controls
                .OfType<Produk_di_Keranjang>()
                .Any(kartu => kartu.diPilih);
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            var produkDipilih = new List<(int id_produk, int jumlah)> ();
            foreach (Produk_di_Keranjang kartu in flpProduk_keranjang.Controls)
            {
                if (kartu.diPilih)
                {
                    produkDipilih.Add((kartu.IdProduk, kartu.JumlahProduk));
                }
            }
            if (produkDipilih.Count == 0)
            {
                MessageBox.Show("Pilih produk yang ingin dibeli.");
                return;
            }
            this.Hide();
            Pembayaran pembayaran = new Pembayaran(serviceAkun, akun, produkDipilih);
            pembayaran.ShowDialog();
            this.Hide();
        }
    }
}
