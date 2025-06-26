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
        public event EventHandler BarangDikembalikan;
        private readonly UserLogin userLogin;
        private readonly Produk produk;
        public int IdTransaksiSewa { get; set; }
        private string _status;
        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                txtStatus.Text = value;
                btnKembalikan.Enabled = value.ToLower() == "dipinjam";
            }
        }
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
        public BarangSewa(UserLogin userLogin, Produk produk)
        {
            InitializeComponent();
            btnKembalikan.Click += btnKembalikan_Click;
            this.userLogin = userLogin;
            this.produk = produk;
        }

        private void btnKembalikan_Click(object sender, EventArgs e)
        {
            if (Status.ToLower() != "dipinjam")
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
                txtDenda.Visible = true;
                txtDenda.Text = denda.ToString("C2");
                MessageBox.Show($"Barang dikembalikan terlambat {hariTerlambat} hari. Denda: {denda:C2}", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Barang berhasil dikembalikan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var service = new PenyewaanService(userLogin, produk);
            string errorMessage;
            bool sukses = service.KembalikanBarang(IdTransaksiSewa, denda, out errorMessage);
            if (sukses)
            {
                Status = "Sudah dikembalikan";
                BarangDikembalikan?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
