using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using debugging.FormGUI;
using debugging.Service;
using debugging.Model;

namespace debugging
{
    public partial class Pengembalian : Form
    {
        private readonly ServiceProduk serviceProduk;
        private readonly PenyewaanService servicePenyewaan;
        private readonly UserLogin userLogin;
        public Pengembalian(ServiceProduk serviceProduk, PenyewaanService servicePenyewaan, UserLogin akun)
        {
            InitializeComponent();
            this.serviceProduk = serviceProduk;
            this.servicePenyewaan = servicePenyewaan;
            this.userLogin = akun;
        }

        private void Pengembalian_Load(object sender, EventArgs e)
        {
            var data = serviceProduk.GetPenyewaanProdukByCustomer(userLogin.Id);
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("Tidak ada data penyewaan yang ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var item in data)
            {
                if (item.StatusPeminjaman == "Ditolak" || item.StatusPeminjaman == "Sudah Dikembalikan")
                    continue;

                var produk = new Produk
                {
                    id_produk = item.IdProduk,
                    nama = item.NamaProduk,
                    foto = item.FotoProduk
                };

                var barangSewa = new BarangSewa(userLogin, produk)
                {
                    IdTransaksiSewa = item.IdPenyewaan,
                    NamaProduk = item.NamaProduk,
                    TanggalSewa = item.TanggalSewa,
                    JatuhTempo = item.TanggalKembali,
                    Status = item.StatusPeminjaman,
                    FotoProduk = item.FotoProduk
                };
                flpPengembalian.Controls.Add(barangSewa);
            }
        }
    }
}
