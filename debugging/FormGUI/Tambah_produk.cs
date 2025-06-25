using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using debugging.Model;
using debugging.Service;
using debugging.AksesLayer;

namespace debugging.FormGUI 
{
    public partial class Tambah_produk : Form
    {
        private readonly ServiceProduk serviceProduk;
//         public Tambah_produk(ServiceProduk serviceProduk)
        private readonly AksesLayer.IAksesProduk aksesProduk;

        public Tambah_produk(ServiceProduk serviceProduk, AksesLayer.IAksesProduk aksesProduk)
        {
            InitializeComponent();
            this.serviceProduk = serviceProduk;
        }

        private void Tambah_produk_Load(object sender, EventArgs e)
        {
//             try
//             {
//                 comboKategori.DataSource = serviceProduk.GetAllKategori();
//                 comboKategori.DisplayMember = "nama_kategori"; 
//                 comboKategori.ValueMember = "id_kategori";
//             }
//             catch (Exception ex)
//             {
//                 MessageBox.Show("Gagal memuat data kategori: " + ex.Message, "Error");
//                 this.Close();
//             }

            if (comboKategori != null)
            {
                comboKategori.DataSource = GetAllNamaKategori();
                comboKategori.DisplayMember = "kategori";
                comboKategori.ValueMember = "id_kategori";
            }
            else
            {
                MessageBox.Show("ComboBox Kategori tidak ditemukan. Pastikan nama komponen sudah benar.");
            }

            if (comboDisewakan != null)
            {
                comboDisewakan.DataSource = new List<string> { "Ya", "Tidak" };

                comboDisewakan.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("ComboBox Disewakan tidak ditemukan. Pastikan nama komponen sudah benar.");
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
//         private List<Kategori> GetAllNamaKategori()
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
                if (string.IsNullOrWhiteSpace(boxNamaProduk.Text))
                {
                    MessageBox.Show("Nama produk tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    boxNamaProduk.Focus();
                    return;
                }

                if (!decimal.TryParse(boxHarga.Text, out decimal harga))
                {
                    MessageBox.Show("Harga tidak valid. Masukkan angka yang benar.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    boxHarga.Focus();
                    return;
                }

                if (!int.TryParse(boxStok.Text, out int stok))
                {
                    MessageBox.Show("Stok tidak valid. Masukkan angka bulat yang benar.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    boxStok.Focus();
                    return;
                }

                if (comboKategori.SelectedValue == null)
                {
                    MessageBox.Show("Kategori belum dipilih.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboKategori.Focus();
                    return;
                }

                if (comboDisewakan.SelectedItem == null)
                {
                    MessageBox.Show("Status disewakan belum dipilih.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboDisewakan.Focus();
                    return;
                }

                var produk = new Produk
                {
                    nama = boxNamaProduk.Text,
                    harga = harga,
                    stok = stok,
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
                MessageBox.Show($"Gagal menambah produk: {ex.Message}\nDetail: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}