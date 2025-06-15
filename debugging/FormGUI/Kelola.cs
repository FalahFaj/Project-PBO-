using System;
using System.Collections.Generic;
using System.Windows.Forms;
using debugging.Service;
using debugging.Model;
using debugging.AksesLayer;
using debugging.FormGUI;
using debugging.PenghubungDB;

namespace debugging
{
    public partial class Kelola : Form
    {
        private readonly ServiceProduk serviceProduk;
        private readonly AksesProduk aksesProduk;
        private DataGridView dataGridViewProduk;

        public Kelola(ServiceProduk serviceProduk, AksesProduk aksesProduk)
        {
            InitializeComponent();
            this.aksesProduk = aksesProduk; // Use the instance passed as a parameter
            this.serviceProduk = serviceProduk; // Use the instance passed as a parameter

            Load += Kelola_Load;
            InitializeDataGridView();
        }

        private void Kelola_Load(object sender, EventArgs e)
        {
            LoadDataProduk();
        }

        private void InitializeDataGridView()
        {
            dataGridViewProduk = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoGenerateColumns = true,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                Name = "grid_Produk"
            };

            dataGridViewProduk.Columns.Add("id_produk", "ID");
            dataGridViewProduk.Columns.Add("nama", "Nama Produk");
            dataGridViewProduk.Columns.Add("harga", "Harga");
            dataGridViewProduk.Columns.Add("stok", "Stok");
            dataGridViewProduk.Columns.Add("disewakan", "Disewakan");

            Controls.Add(dataGridViewProduk);
        }

        private void LoadDataProduk()
        {
            try
            {
                var produkList = serviceProduk.GetAllProduk();

                if (produkList == null || produkList.Count == 0)
                {
                    MessageBox.Show("Tidak ada data produk ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridViewProduk.AutoGenerateColumns = true;
                dataGridViewProduk.DataSource = produkList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isDeleteMode = false;
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (!isDeleteMode)
            {
                txtId.Enabled = true;
                txtId.Focus();
                isDeleteMode = true;
                MessageBox.Show("Masukkan ID produk yang ingin dihapus, lalu tekan tombol Hapus lagi untuk konfirmasi.");
                return;
            }
            if (int.TryParse(txtId.Text, out int id))
            {
                aksesProduk.HapusProduk(id);
                MessageBox.Show("Produk berhasil dihapus.");
                txtId.Text = "";
                txtId.Enabled = false;
                isDeleteMode = false;
                LoadDataProduk();
            }
            else
            {
                MessageBox.Show("ID produk tidak valid.");
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Tambah_produk tambahProdukForm = new Tambah_produk(serviceProduk, aksesProduk);
            tambahProdukForm.ShowDialog();
            if (tambahProdukForm.DialogResult == DialogResult.OK)
            {
                LoadDataProduk();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update_Produk updateProdukForm = new update_Produk(serviceProduk);
            updateProdukForm.ShowDialog();
        }
    }
}