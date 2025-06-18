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

            if (!isDeleteMode)
            {
                txtId.Enabled = true;
                txtId.Focus();
                isDeleteMode = true;
                MessageBox.Show("Masukkan ID produk yang ingin dihapus di kotak teks, lalu tekan tombol 'Delete' lagi untuk konfirmasi.");
                return;
            }


            if (int.TryParse(txtId.Text, out int idToDelete))
            {
                DialogResult confirmResult = MessageBox.Show(
                    $"Anda yakin ingin menghapus produk dengan ID: {idToDelete}? Tindakan ini tidak dapat dibatalkan.",
                    "Konfirmasi Hapus Produk",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        aksesProduk.HapusProduk(idToDelete);
                        MessageBox.Show("Produk berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtId.Text = "";
                        txtId.Enabled = false;
                        isDeleteMode = false;
                        LoadDataProduk();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Gagal menghapus produk: {ex.Message}\nDetail: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtId.Text = "";
                    txtId.Enabled = false;
                    isDeleteMode = false;
                }
            }
            else
            {
                MessageBox.Show("ID produk tidak valid. Mohon masukkan angka.", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Text = "";
                txtId.Enabled = false;
                isDeleteMode = false;
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
            update_Produk updateProdukForm = new update_Produk(serviceProduk, aksesProduk);
            updateProdukForm.ShowDialog();

        }

        private void grid_Produk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}