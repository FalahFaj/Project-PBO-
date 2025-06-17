using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using debugging.Model;
using debugging.Service;

namespace debugging.FormGUI 
{
    public partial class Tambah_produk : Form
    {
        private readonly ServiceProduk serviceProduk;
        public Tambah_produk(ServiceProduk serviceProduk)
        {
            InitializeComponent();
            this.serviceProduk = serviceProduk;
        }

        private void Tambah_produk_Load(object sender, EventArgs e)
        {
            try
            {
                comboKategori.DataSource = serviceProduk.GetAllKategori();
                comboKategori.DisplayMember = "nama_kategori"; 
                comboKategori.ValueMember = "id_kategori";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data kategori: " + ex.Message, "Error");
                this.Close();
            }

            comboDisewakan.DataSource = new List<string> { "Ya", "Tidak" };
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(boxNamaProduk.Text) ||
                string.IsNullOrWhiteSpace(boxHarga.Text) ||
                string.IsNullOrWhiteSpace(boxStok.Text))
            {
                MessageBox.Show("Semua field harus diisi.", "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var produk = new Produk
                {
                    nama = boxNamaProduk.Text,
                    harga = decimal.Parse(boxHarga.Text),
                    stok = int.Parse(boxStok.Text),
                    id_kategori = (int)comboKategori.SelectedValue,
                    disewakan = comboDisewakan.SelectedItem.ToString() == "Ya"
                };
                serviceProduk.TambahProduk(produk);

                MessageBox.Show("Produk berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Format Harga atau Stok tidak valid. Harap masukkan angka.", "Error Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menambah produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}