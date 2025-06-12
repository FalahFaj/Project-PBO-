using System;
using System.Collections.Generic;
using System.Windows.Forms;
using debugging.Model;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

namespace debugging
{
    public partial class Kelola_Product : Form
    {
        private List<Produk> daftarProduk = new List<Produk>();
        private int nextId = 1;

        public Kelola_Product()
        {
            InitializeComponent();
        }

        private void Kelola_Product_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = daftarProduk;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataGridView1.Columns["Id"] != null)
            {
                dataGridView1.Columns["Id"].ReadOnly = true;
            }
        }

        private void ClearForm()
        {
            txtNama.Text = "";
            txtHarga.Text = "";
            txtStok.Text = "";
            txtDeskripsi.Text = "";
            dataGridView1.ClearSelection();
            dataGridView1.Tag = null;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) || string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                MessageBox.Show("Nama dan Harga wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Produk produkBaru = new Produk()
            {
                nama = txtNama.Text,
                harga = decimal.TryParse(txtHarga.Text, out decimal harga) ? harga : 0,
                stok = int.TryParse(txtStok.Text, out int stock) ? stock : 0,
                //Deskripsi = txtDeskripsi.Text
            };

            daftarProduk.Add(produkBaru);
            RefreshDataGrid();
            ClearForm();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["Id"].Value is int selectedId)
                {
                    var selectedProduk = daftarProduk.Find(p => p.id_produk == selectedId);
                    if (selectedProduk != null)
                    {
                        txtNama.Text = selectedProduk.nama;
                        txtHarga.Text = selectedProduk.harga.ToString();
                        txtStok.Text = selectedProduk.stok.ToString();
                        //txtDeskripsi.Text = selectedProduk.Deskripsi;
                        dataGridView1.Tag = selectedProduk.id_kategori;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Tag is int index && index >= 0 && index < daftarProduk.Count)
            {
                var produk = daftarProduk[index];
                produk.nama = txtNama.Text;
                produk.harga = decimal.TryParse(txtHarga.Text, out decimal harga) ? harga : 0;
                produk.stok = int.TryParse(txtStok.Text, out int stock) ? stock : 0;
                //produk.Deskripsi = txtDeskripsi.Text;

                RefreshDataGrid();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin di-update terlebih dahulu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Tag is int index && index >= 0 && index < daftarProduk.Count)
            {
                var confirm = MessageBox.Show("Yakin ingin menghapus produk ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    daftarProduk.RemoveAt(index);
                    RefreshDataGrid();
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDeskripsi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
