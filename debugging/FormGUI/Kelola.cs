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

        public Kelola(ServiceProduk serviceProduk, AksesProduk aksesProduk)
        {
            InitializeComponent();
            this.aksesProduk = aksesProduk;
            this.serviceProduk = serviceProduk;

            Load += Kelola_Load;
            grid_Produk.CellFormatting += grid_Produk_CellFormatting;
        }

        private void Kelola_Load(object sender, EventArgs e)
        {

            grid_Produk.AutoGenerateColumns = true;
            LoadDataProduk();
        }

        private void LoadDataProduk()
        {
            try
            {
                var produkList = serviceProduk.GetAllProduk();

                if (produkList == null || produkList.Count == 0)
                {
                    MessageBox.Show("Tidak ada data produk ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid_Produk.DataSource = null;
                    return;
                    return;
                }

                grid_Produk.DataSource = produkList;

                if (grid_Produk.Columns.Contains("Disewakan"))
                {
                    DataGridViewColumn disewakanColumn = grid_Produk.Columns["Disewakan"];
                    if (!(disewakanColumn is DataGridViewTextBoxColumn))
                    {
 
                        int columnIndex = disewakanColumn.Index;
                        string headerText = disewakanColumn.HeaderText;
                        grid_Produk.Columns.Remove(disewakanColumn);

                        DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn
                        {
                            Name = "Disewakan", 
                            HeaderText = headerText,
                            DataPropertyName = "Disewakan" 
                        };
                        grid_Produk.Columns.Insert(columnIndex, newColumn);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grid_Produk_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grid_Produk.Columns[e.ColumnIndex].Name == "Disewakan" && e.Value != null)
            {
                if (e.Value is bool boolValue)
                {
                    e.Value = boolValue ? "Ya" : "Tidak";
                    e.FormattingApplied = true;
                }
                else if (e.Value is int intValue)
                {
                    e.Value = (intValue == 1) ? "Ya" : "Tidak";
                    e.FormattingApplied = true;
                }
                else if (e.Value is string stringValue)
                {
                    if (bool.TryParse(stringValue, out bool parsedBool))
                    {
                        e.Value = parsedBool ? "Ya" : "Tidak";
                        e.FormattingApplied = true;
                    }
                    else if (int.TryParse(stringValue, out int parsedInt))
                    {
                        e.Value = (parsedInt == 1) ? "Ya" : "Tidak";
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private bool isDeleteMode = false;
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (grid_Produk.SelectedRows.Count > 0)
            {
                int idToDelete = Convert.ToInt32(grid_Produk.SelectedRows[0].Cells["id_produk"].Value);
                string namaProduk = grid_Produk.SelectedRows[0].Cells["nama"].Value.ToString();

                DialogResult confirmResult = MessageBox.Show(
                    $"Anda yakin ingin menghapus produk '{namaProduk}' (ID: {idToDelete})?",
                    "Konfirmasi Hapus Produk",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        serviceProduk.HapusProduk(idToDelete);
                        MessageBox.Show("Produk berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataProduk(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Gagal menghapus produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih satu baris produk dari tabel yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (grid_Produk.SelectedRows.Count > 0)
            {
                try
                {
                    int idToUpdate = Convert.ToInt32(grid_Produk.SelectedRows[0].Cells["id_produk"].Value);
                    update_Produk updateForm = new update_Produk(idToUpdate, this.serviceProduk);
                    DialogResult result = updateForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        LoadDataProduk();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi error saat mencoba membuka form update: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih satu baris produk dari tabel yang ingin di-update.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grid_Produk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}