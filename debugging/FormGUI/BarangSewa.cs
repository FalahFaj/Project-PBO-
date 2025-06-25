using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using debugging.Service;
using debugging.Model;
using debugging.AksesLayer;

namespace debugging.FormGUI
{
    public partial class BarangSewa : UserControl
    {
        private readonly UserLogin userLogin;
        private readonly Produk produk;
        public int IdTransaksiSewa { get; set; }
        public string FotoProduk
        {
            set
            {
                if (!string.IsNullOrEmpty(value) && System.IO.File.Exists(value))
                {
                    picProdukDisewa.Image = Image.FromFile(value);
                }
                else
                {
                    picProdukDisewa.Image = null;
                }
            }
        }
        public string NamaProduk
        {
            get => txtNamaProduk.Text;
            set => txtNamaProduk.Text = value;
        }
        public DateTime TanggalSewa
        {
            get => DateTime.Parse(txtTglSewa.Text);
            set => txtTglSewa.Text = value.ToString("dd/MM/yyyy");
        }
        public DateTime JatuhTempo
        {
            get => DateTime.Parse(txtTglJatuhTempo.Text);
            set => txtTglJatuhTempo.Text = value.ToString("dd/MM/yyyy");
        }
        public string Status
        {
            get => txtStatus.Text;
            set => txtStatus.Text = value;
        }
        public BarangSewa(UserLogin userLogin, Produk produk)
        {
            InitializeComponent();
            btnKembalikan.Click += btnKembalikan_Click;
            this.userLogin = userLogin;
            this.produk = produk;
            if (Status == "Menunggu Konfirmasi")
            {
                btnKembalikan.Visible = false;
            }
        }

        private void btnKembalikan_Click(object sender, EventArgs e)
        {
            if (Status == "Sudah dikembalikan")
            {
                MessageBox.Show("Barang sudah dikembalikan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DateTime tanggalKembali = DateTime.Now;
            decimal denda = 0;
            int hariTerlambat = (tanggalKembali - JatuhTempo).Days;
            if (hariTerlambat > 0)
            {
                denda = hariTerlambat * 5000;
                txtDenda.Text = denda.ToString("C2");
                MessageBox.Show($"Barang dikembalikan terlambat {hariTerlambat} hari. Denda: {denda:C2}", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtDenda.Text = "Rp 0,00";
                MessageBox.Show("Barang dikembalikan tepat waktu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Status = "Sudah dikembalikan";
            btnKembalikan.Enabled = false;

            var service = new PenyewaanService(userLogin, produk);
            string errorMessage;
            bool sukses = service.KembalikanBarang(IdTransaksiSewa, denda, out errorMessage);
        }
    }
}
