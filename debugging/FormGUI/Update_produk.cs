using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using debugging.Model;
using debugging.PenghubungDB;
using debugging.Service;
using System.Drawing; 

namespace debugging
{
    public partial class update_Produk : Form
    {
        private readonly ServiceProduk serviceProduk;
        private Produk produkTerpilih; 

        public update_Produk(ServiceProduk service)
        {
            InitializeComponent();
            this.serviceProduk = service;
            this.Load += new System.EventHandler(this.update_Produk_Load);
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click); 
            this.button1.Click += new System.EventHandler(this.button1_Click); 
            this.comboBoxkategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxkategori_SelectedIndexChanged);
        }

        private void update_Produk_Load(object sender, EventArgs e)
        {
            SetupGrid();
            this.tampilkan_id_grid.CellFormatting += UpdateGrid_CellFormatting;

            comboBoxkategori.Items.AddRange(new string[] { "Nama", "Harga", "Stok", "Disewakan", "Kategori" });

            try
            {
                comboBoxKategoriUpdate.DataSource = serviceProduk.GetAllKategori();
                comboBoxKategoriUpdate.DisplayMember = "nama_kategori"; 
                comboBoxKategoriUpdate.ValueMember = "id_kategori";
                comboBoxKategoriUpdate.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data kategori: " + ex.Message);
            }
        }

        private void SetupGrid()
        {
            tampilkan_id_grid.Columns.Clear();
            tampilkan_id_grid.AutoGenerateColumns = false;
            tampilkan_id_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            tampilkan_id_grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "id_produk" });
            tampilkan_id_grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nama Produk", DataPropertyName = "nama" });
            tampilkan_id_grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Harga", DataPropertyName = "harga", DefaultCellStyle = { Format = "C0" } });
            tampilkan_id_grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stok", DataPropertyName = "stok" });
            tampilkan_id_grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID Kategori", DataPropertyName = "id_kategori" });
            tampilkan_id_grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "StatusDisewakan", HeaderText = "Disewakan", DataPropertyName = "disewakan" });
        }
        private void UpdateGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.tampilkan_id_grid.Columns[e.ColumnIndex].Name == "StatusDisewakan" && e.Value is bool)
            {
                e.Value = (bool)e.Value ? "YA" : "TIDAK";
                e.FormattingApplied = true;
            }
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblCari_id.Text.Trim(), out int id))
            {
                produkTerpilih = serviceProduk.GetProdukBById(id);
                if (produkTerpilih != null)
                {
                    tampilkan_id_grid.DataSource = new List<Produk> { produkTerpilih };
                }
                else
                {
                    MessageBox.Show("Produk dengan ID tersebut tidak ditemukan.");
                    tampilkan_id_grid.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("ID produk harus berupa angka.");
            }
        }
        private void comboBoxkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pilihan = comboBoxkategori.SelectedItem?.ToString();
            comboBoxKategoriUpdate.Enabled = pilihan == "Kategori";
            textBoxUpdateValue.Enabled = pilihan != "Kategori";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (produkTerpilih == null)
            {
                MessageBox.Show("Cari produk berdasarkan ID terlebih dahulu.", "Produk Belum Dipilih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fieldToUpdate = comboBoxkategori.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(fieldToUpdate))
            {
                MessageBox.Show("Pilih field yang ingin diupdate dari daftar.", "Field Belum Dipilih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                switch (fieldToUpdate)
                {
                    case "Nama": produkTerpilih.nama = textBoxUpdateValue.Text; break;
                    case "Harga": produkTerpilih.harga = decimal.Parse(textBoxUpdateValue.Text); break;
                    case "Stok": produkTerpilih.stok = int.Parse(textBoxUpdateValue.Text); break;
                    case "Disewakan": produkTerpilih.disewakan = textBoxUpdateValue.Text.Trim().ToLower() == "ya" || textBoxUpdateValue.Text.Trim().ToLower() == "true"; break;
                    case "Kategori": produkTerpilih.id_kategori = (int)comboBoxKategoriUpdate.SelectedValue; break;
                    default: MessageBox.Show("Field yang dipilih tidak valid."); return;
                }

                serviceProduk.UpdateProduk(produkTerpilih);

                MessageBox.Show($"Produk '{produkTerpilih.nama}' berhasil diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tampilkan_id_grid.DataSource = null;
                tampilkan_id_grid.DataSource = new List<Produk> { produkTerpilih };
            }
            catch (FormatException)
            {
                MessageBox.Show("Format nilai baru tidak valid. Pastikan Harga dan Stok adalah angka.", "Error Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat mengupdate: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}