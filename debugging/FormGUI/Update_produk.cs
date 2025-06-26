using debugging.Model;
using debugging.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace debugging
{
    public partial class update_Produk : Form
    {
        private readonly ServiceProduk serviceProduk;
        private readonly int produkIdToUpdate;
        private Produk produkTerpilih;

        public update_Produk(int produkId, ServiceProduk service)
        {
            InitializeComponent();
            this.produkIdToUpdate = produkId;
            this.serviceProduk = service;
        }

        private void update_Produk_Load(object sender, EventArgs e)
        {
            tampilkan_id_grid.ReadOnly = true;
            tampilkan_id_grid.RowHeadersVisible = false;
            tampilkan_id_grid.AllowUserToAddRows = false;
            tampilkan_id_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tampilkan_id_grid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tampilkan_id_grid.AutoResizeColumnHeadersHeight();
            comboBoxkategori.Items.Clear();
            comboBoxkategori.Items.Add("Nama");
            comboBoxkategori.Items.Add("Deskripsi");
            comboBoxkategori.Items.Add("Harga");
            comboBoxkategori.Items.Add("Stok");
            textBoxUpdateValue.Enabled = true;
            lblCari_id.Text = this.produkIdToUpdate.ToString();
            btn_ok.PerformClick();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblCari_id.Text, out int id))
            {
                produkTerpilih = serviceProduk.GetProdukBById(id);

                tampilkan_id_grid.Columns.Clear();
                tampilkan_id_grid.Columns.Add(new DataGridViewTextBoxColumn() { Name = "id_produk", HeaderText = "ID Produk", DataPropertyName = "id_produk" });
                tampilkan_id_grid.Columns.Add(new DataGridViewTextBoxColumn() { Name = "nama", HeaderText = "Nama", DataPropertyName = "nama" });
                tampilkan_id_grid.Columns.Add(new DataGridViewTextBoxColumn() { Name = "harga", HeaderText = "Harga", DataPropertyName = "harga" });
                tampilkan_id_grid.Columns.Add(new DataGridViewTextBoxColumn() { Name = "stok", HeaderText = "Stok", DataPropertyName = "stok" });
                tampilkan_id_grid.Columns.Add(new DataGridViewTextBoxColumn() { Name = "foto", HeaderText = "Foto", DataPropertyName = "foto" });
                tampilkan_id_grid.Columns.Add(new DataGridViewTextBoxColumn() { Name = "id_kategori", HeaderText = "ID Kategori", DataPropertyName = "id_kategori" });
                tampilkan_id_grid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "disewakan",
                    HeaderText = "Disewakan",
                    DataPropertyName = "disewakan",
                    ReadOnly = true
                });
                tampilkan_id_grid.Columns.Add(new DataGridViewTextBoxColumn() { Name = "KategoriNama", HeaderText = "Kategori", DataPropertyName = "KategoriNama" });

                var produkUntukGrid = new List<dynamic>();
                if (produkTerpilih != null)
                {
                    string namaKategori = "";
                    if (produkTerpilih.id_kategori != 0)
                    {
                        var kategoriObj = serviceProduk.GetKategoriBById(produkTerpilih.id_kategori);
                        if (kategoriObj != null)
                        {
                            namaKategori = kategoriObj.kategori;
                        }
                    }

                    produkUntukGrid.Add(new
                    {
                        produkTerpilih.id_produk,
                        produkTerpilih.nama,
                        produkTerpilih.harga,
                        produkTerpilih.stok,
                        produkTerpilih.foto,
                        produkTerpilih.id_kategori,
                        produkTerpilih.disewakan,
                        KategoriNama = namaKategori
                    });
                }
                tampilkan_id_grid.DataSource = produkUntukGrid;

                if (produkTerpilih == null) MessageBox.Show("Produk tidak ditemukan.");
            }
            else
            {
                MessageBox.Show("ID produk harus berupa angka.");
            }
        }

        private void comboBoxkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxUpdateValue.Enabled = true;
            textBoxUpdateValue.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (produkTerpilih == null)
            {
                MessageBox.Show("Tidak ada produk yang dipilih untuk diupdate.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fieldToUpdate = comboBoxkategori.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(fieldToUpdate))
            {
                MessageBox.Show("Silakan pilih field yang ingin diupdate.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string newValue = textBoxUpdateValue.Text;
                if (string.IsNullOrWhiteSpace(newValue))
                {
                    MessageBox.Show("Nilai baru tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                switch (fieldToUpdate)
                {
                    case "Nama":
                        produkTerpilih.nama = newValue;
                        break;
                    case "Harga":
                        if (decimal.TryParse(newValue, out decimal hargaBaru)) produkTerpilih.harga = hargaBaru;
                        else { MessageBox.Show("Input harga harus angka.", "Error Input"); return; }
                        break;
                    case "Stok":
                        if (int.TryParse(newValue, out int stokBaru)) produkTerpilih.stok = stokBaru;
                        else { MessageBox.Show("Input stok harus angka.", "Error Input"); return; }
                        break;
                }

                serviceProduk.UpdateProduk(produkTerpilih);
                btn_ok.PerformClick();
                textBoxUpdateValue.Clear();
                MessageBox.Show($"Field '{fieldToUpdate}' berhasil diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal update produk: {ex.Message}", "Error Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}