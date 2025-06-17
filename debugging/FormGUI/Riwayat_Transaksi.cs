using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using debugging.Model;
using debugging.Service;

namespace debugging
{
    public partial class Riwayat_Transaksi : Form
    {
        private readonly IServiceRiwayat serviceRiwayat;
        private List<RiwayatViewModel> semuaTransaksi;
        public Riwayat_Transaksi(IServiceRiwayat serviceRiwayat)
        {
            InitializeComponent();
            this.serviceRiwayat = serviceRiwayat;
            this.Load += new System.EventHandler(this.Riwayat_Transaksi_Load);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.button4.Click += new System.EventHandler(this.button4_Click); 
        }

        private void Riwayat_Transaksi_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            comboBox1.Items.AddRange(new object[] { "Semua", "Sewa", "Beli" });
            comboBox1.SelectedIndex = 0;
            LoadData();
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tipe", DataPropertyName = "Tipe" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "IdTransaksi" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nama Pelanggan", DataPropertyName = "NamaPelanggan" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tanggal", DataPropertyName = "Tanggal", DefaultCellStyle = { Format = "dd-MM-yyyy" } });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Keterangan", DataPropertyName = "KeteranganProduk" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status" });
        }
        private void LoadData()
        {
            try
            {
                semuaTransaksi = serviceRiwayat.GetSemuaRiwayat();
                dataGridView1.DataSource = semuaTransaksi.OrderByDescending(t => t.Tanggal).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (semuaTransaksi == null) return;
            string filter = comboBox1.SelectedItem.ToString();
            List<RiwayatViewModel> dataTersaring;

            if (filter == "Semua")
            {
                dataTersaring = semuaTransaksi;
            }
            else
            {
                dataTersaring = semuaTransaksi.Where(t => t.Tipe == filter).ToList();
            }
            dataGridView1.DataSource = dataTersaring.OrderByDescending(t => t.Tanggal).ToList();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text.Trim(), out int idToUpdate))
            {
                MessageBox.Show("Harap masukkan ID penyewaan yang valid.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show($"Pilih status baru untuk transaksi ID {idToUpdate}:\n\n[YES] = Disetujui\n[NO] = Ditolak",
                                               "Konfirmasi Update Status", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel) return;

            string newStatus = (dialogResult == DialogResult.Yes) ? "Disetujui" : "Ditolak";
            
            try
            {
                serviceRiwayat.UpdateStatusPenyewaan(idToUpdate, newStatus);
                MessageBox.Show($"Status untuk ID {idToUpdate} berhasil diubah.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LoadData();
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal update: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Unused or other methods
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        public void ExportToPDF(DataGridView dataGridView) {  }
        private void ExportPDF_Click(object sender, EventArgs e) { ExportToPDF(dataGridView1); }
        private void button2_Click(object sender, EventArgs e) { Application.Exit(); }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        #endregion
    }
}