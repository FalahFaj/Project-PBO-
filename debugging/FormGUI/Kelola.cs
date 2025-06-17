using System;
using System.Windows.Forms;
using debugging.Service;
using debugging.Model;
using debugging.AksesLayer;
using debugging.FormGUI;

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
            this.Load += Kelola_Load;
        }

        private void Kelola_Load(object sender, EventArgs e)
        {
            this.grid_Produk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Produk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.grid_Produk.MultiSelect = false;
            this.grid_Produk.ReadOnly = true;
            this.grid_Produk.AutoGenerateColumns = false;

            SetupDataGridViewColumns();
            this.grid_Produk.CellFormatting += grid_Produk_CellFormatting;
            LoadDataProduk();
        }

        private void SetupDataGridViewColumns()
        {
            grid_Produk.Columns.Clear();
            grid_Produk.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "id_produk" });
            grid_Produk.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nama Produk", DataPropertyName = "nama" });
            grid_Produk.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Harga", DataPropertyName = "harga", DefaultCellStyle = { Format = "C0" } });
            grid_Produk.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stok", DataPropertyName = "stok" });
            grid_Produk.Columns.Add(new DataGridViewTextBoxColumn { Name = "DisewakanColumn", HeaderText = "Disewakan", DataPropertyName = "disewakan" });
        }

        private void grid_Produk_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.grid_Produk.Columns[e.ColumnIndex].Name == "DisewakanColumn" && e.Value is bool)
            {
                e.Value = (bool)e.Value ? "YA" : "TIDAK";
                e.FormattingApplied = true;
            }
        }

        private void LoadDataProduk()
        {
            try
            {
                var produkList = serviceProduk.GetAllProduk();
                grid_Produk.DataSource = produkList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data produk: {ex.Message}", "Error");
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (Tambah_produk tambahProdukForm = new Tambah_produk(serviceProduk))
            {
                if (tambahProdukForm.ShowDialog() == DialogResult.OK) { LoadDataProduk(); }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Karena form update akan mencari ID sendiri, kita tidak perlu memilih baris di sini.
            // Cukup buka form update.
            using (var updateForm = new update_Produk(this.serviceProduk))
            {
                // Gunakan ShowDialog() agar form Kelola menunggu sampai form update ditutup
                updateForm.ShowDialog();


                LoadDataProduk();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (grid_Produk.CurrentRow == null) { MessageBox.Show("Silakan pilih produk untuk dihapus."); return; }
            var produkToDelete = (Produk)grid_Produk.CurrentRow.DataBoundItem;
            var result = MessageBox.Show($"Yakin ingin menghapus '{produkToDelete.nama}'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    serviceProduk.HapusProduk(produkToDelete.id_produk);
                    LoadDataProduk();
                }
                catch (Exception ex) { MessageBox.Show($"Gagal menghapus: {ex.Message}"); }
            }
        }

        private void grid_Produk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}