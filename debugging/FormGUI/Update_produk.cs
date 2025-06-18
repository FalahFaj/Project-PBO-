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
using debugging.PenghubungDB;
using debugging.AksesLayer;

namespace debugging
{
    public partial class update_Produk : Form
    {
        private readonly ServiceProduk serviceProduk;
        private readonly AksesLayer.IAksesProduk aksesProduk;
        private Produk produkTerpilih;
        public update_Produk(ServiceProduk serviceProduk, AksesLayer.IAksesProduk aksesProduk)
        {
            InitializeComponent();
            this.comboBoxkategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxkategori_SelectedIndexChanged);
            this.serviceProduk = serviceProduk ?? throw new ArgumentNullException(nameof(serviceProduk));
            this.aksesProduk = aksesProduk ?? throw new ArgumentNullException(nameof(aksesProduk));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            comboBoxkategori.Items.AddRange(new string[] { "Nama", "Harga", "Stok", "Disewakan" });
        }

        private void update_Produk_Load(object sender, EventArgs e)
        {
            comboBoxkategori.Items.AddRange(new string[] { "Nama", "Harga", "Stok", "Disewakan" });

            comboBoxKategoriUpdate.DataSource = GetAllKategori();
            comboBoxKategoriUpdate.DisplayMember = "kategori";
            comboBoxKategoriUpdate.ValueMember = "id_kategori";
            comboBoxKategoriUpdate.Enabled = false;
            tampilkan_id_grid.AutoGenerateColumns = true;
            tampilkan_id_grid.ColumnHeadersVisible = true;
            tampilkan_id_grid.RowHeadersVisible = false;
            tampilkan_id_grid.AllowUserToAddRows = false;
            tampilkan_id_grid.AllowUserToDeleteRows = false;
            tampilkan_id_grid.ReadOnly = true;
            tampilkan_id_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tampilkan_id_grid.CellFormatting += Tampilkan_id_grid_CellFormatting;
        }
        private List<Kategori> GetAllKategori()
        {
            using (var db = new KoneksiDB())
            {
                return db.kategori.ToList();
            }
        }
        private void comboBoxkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKategoriUpdate.Enabled = comboBoxkategori.SelectedItem?.ToString() == "Kategori";
            textBoxUpdateValue.Enabled = comboBoxkategori.SelectedItem?.ToString() != "Kategori";
            string selectedItemText = comboBoxkategori.SelectedItem?.ToString();
            bool isKategoriSelected = selectedItemText?.Trim().Equals("Kategori", StringComparison.OrdinalIgnoreCase) ?? false;

            comboBoxKategoriUpdate.Enabled = isKategoriSelected;
            textBoxUpdateValue.Enabled = !isKategoriSelected;
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblCari_id.Text, out int id))
            {
                produkTerpilih = serviceProduk.GetProdukBById(id);
                if (produkTerpilih != null)
                {
                    tampilkan_id_grid.DataSource = new List<Produk> { produkTerpilih };
                    GantiKolomDisewakanKeTeks();
                    ConfigureDataGridViewColumns();
                    tampilkan_id_grid.Invalidate();
                }
                else
                {
                    MessageBox.Show("Produk tidak ditemukan.");
                    tampilkan_id_grid.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("ID produk harus berupa angka.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (produkTerpilih == null)
            {
                MessageBox.Show("Cari produk terlebih dahulu sebelum melakukan update.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string field = comboBoxkategori.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(field))
            {
                MessageBox.Show("Pilih field yang ingin diupdate.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                switch (field)
                {
                    case "Nama":
                        if (string.IsNullOrWhiteSpace(textBoxUpdateValue.Text)) { MessageBox.Show("Nama produk tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                        produkTerpilih.nama = textBoxUpdateValue.Text;
                        break;
                    case "Harga":
                        if (!decimal.TryParse(textBoxUpdateValue.Text, out decimal harga)) { MessageBox.Show("Harga tidak valid. Masukkan angka.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                        produkTerpilih.harga = harga;
                        break;
                    case "Stok":
                        if (!int.TryParse(textBoxUpdateValue.Text, out int stok)) { MessageBox.Show("Stok tidak valid. Masukkan angka.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                        produkTerpilih.stok = stok;
                        break;
                    case "Disewakan":
                        string disewakanText = textBoxUpdateValue.Text.ToLower().Trim();
                        if (disewakanText == "ya" || disewakanText == "true") { produkTerpilih.disewakan = true; }
                        else if (disewakanText == "tidak" || disewakanText == "false") { produkTerpilih.disewakan = false; }
                        else { MessageBox.Show("Status 'Disewakan' harus 'Ya' atau 'Tidak'.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                        break;
                    case "Kategori":
                        if (comboBoxKategoriUpdate.SelectedValue == null) { MessageBox.Show("Kategori belum dipilih.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                        produkTerpilih.id_kategori = (int)comboBoxKategoriUpdate.SelectedValue;
                        break;
                    default:
                        MessageBox.Show("Pilihan field tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                aksesProduk.UpdateProduk(produkTerpilih);

                tampilkan_id_grid.DataSource = null;
                tampilkan_id_grid.DataSource = new List<Produk> { produkTerpilih };
                ConfigureDataGridViewColumns();

                GantiKolomDisewakanKeTeks();
                tampilkan_id_grid.Invalidate();

                MessageBox.Show("Produk berhasil diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Format input tidak sesuai dengan tipe data field yang dipilih.", "Error Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal update produk: {ex.Message}\nDetail: {ex.InnerException?.Message}", "Error Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GantiKolomDisewakanKeTeks()
        {
            if (tampilkan_id_grid.Columns.Contains("Disewakan"))
            {
                DataGridViewColumn disewakanColumn = tampilkan_id_grid.Columns["Disewakan"];
                if (!(disewakanColumn is DataGridViewTextBoxColumn))
                {
                    int columnIndex = disewakanColumn.Index;
                    string headerText = disewakanColumn.HeaderText;
                    string dataPropertyName = disewakanColumn.DataPropertyName;
                    tampilkan_id_grid.Columns.Remove(disewakanColumn);
                    DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "Disewakan",
                        HeaderText = headerText,
                        DataPropertyName = dataPropertyName
                    };

                    tampilkan_id_grid.Columns.Insert(columnIndex, newColumn);
                }
            }
        }
        private void Tampilkan_id_grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tampilkan_id_grid.Columns.Contains("Disewakan") && tampilkan_id_grid.Columns[e.ColumnIndex].Name == "Disewakan" && e.Value != null)
            {
                if (e.Value is bool boolValue) { e.Value = boolValue ? "Ya" : "Tidak"; e.FormattingApplied = true; }
                else if (e.Value is string stringValue)
                {
                    string lowerString = stringValue.ToLower().Trim();
                    if (lowerString == "true" || lowerString == "ya") { e.Value = "Ya"; e.FormattingApplied = true; }
                    else if (lowerString == "false" || lowerString == "tidak") { e.Value = "Tidak"; e.FormattingApplied = true; }
                }
                else if (e.Value is int intValue) { e.Value = (intValue == 1) ? "Ya" : "Tidak"; e.FormattingApplied = true; }
                return;
            }
        }
        private void ConfigureDataGridViewColumns()
        {
            if (tampilkan_id_grid.DataSource == null) return;
            if (tampilkan_id_grid.Columns.Contains("Disewakan"))
            {
                DataGridViewColumn disewakanColumn = tampilkan_id_grid.Columns["Disewakan"];
                if (!(disewakanColumn is DataGridViewTextBoxColumn))
                {
                    int columnIndex = disewakanColumn.Index;
                    string headerText = disewakanColumn.HeaderText;
                    string dataPropertyName = disewakanColumn.DataPropertyName;
                    tampilkan_id_grid.Columns.Remove(disewakanColumn);
                    DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "Disewakan",
                        HeaderText = headerText,
                        DataPropertyName = dataPropertyName
                    };
                    tampilkan_id_grid.Columns.Insert(columnIndex, newColumn);
                }
            }


            if (tampilkan_id_grid.Columns.Contains("Kategori"))
            {
                tampilkan_id_grid.Columns.Remove("Kategori");
            }
            if (tampilkan_id_grid.Columns.Contains("id_kategori"))
            {
                tampilkan_id_grid.Columns["id_kategori"].Visible = false;
            }

            if (!tampilkan_id_grid.Columns.Contains("NamaKategoriProduk"))
            {
                DataGridViewTextBoxColumn kategoriNameColumn = new DataGridViewTextBoxColumn
                {
                    Name = "NamaKategoriProduk",
                    HeaderText = "Kategori",
                    DataPropertyName = "Kategori.kategori"
                };

                int insertIndex = tampilkan_id_grid.Columns.Contains("id_kategori") ? tampilkan_id_grid.Columns["id_kategori"].Index + 1 : tampilkan_id_grid.Columns.Count;
                tampilkan_id_grid.Columns.Insert(insertIndex, kategoriNameColumn);
            }
        }
        private void textBoxUpdateValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxKategoriUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}