using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Forms;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using Color = MigraDoc.DocumentObjectModel.Color;
using Font = MigraDoc.DocumentObjectModel.Font;
using debugging.Model;
using debugging.PenghubungDB;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace debugging
{
    [NotMapped]
    public partial class Riwayat_Transaksi : Form
    {
        private readonly KoneksiDB db = new KoneksiDB();

        public Riwayat_Transaksi()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            menuDisetujui.Click += new EventHandler(menuDisetujui_Click);
            menuDitolak.Click += new EventHandler(menuDitolak_Click);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Riwayat_Transaksi_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#3F51B5");
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            LoadRiwayatTransaksi();
        }

        private void LoadRiwayatTransaksi()
        {
            var data = (from p in db.penyewaan
                        join c in db.customer on p.id_customer equals c.id_customer
                        join d_group in db.item_penyewaan on p.id_penyewaan equals d_group.id_penyewaan into itemGroup
                        select new
                        {
                            IdPenyewaan = p.id_penyewaan,
                            NamaPenyewa = c.nama,
                            Produk = string.Join(", ", itemGroup.Select(item => db.produk.FirstOrDefault(pr => pr.id_produk == item.id_produk).nama)),
                            TanggalPenyewaan = p.tanggal_sewa,
                            BatasPenyewaan = p.tanggal_kembali,
                            NominalDP = p.pembayaran_dp,
                            StatusDP = p.status_dp,
                            StatusPenyewaan = p.status_peminjaman
                        }).ToList();

            dataGridView1.DataSource = data;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["Column1"].Value = i + 1;
            }

            Column2.DataPropertyName = "NamaPenyewa";
            Column3.DataPropertyName = "Produk";
            Column4.DataPropertyName = "TanggalPenyewaan";
            Column5.DataPropertyName = "BatasPenyewaan";
            Column6.DataPropertyName = "NominalDP";
            Column7.DataPropertyName = "StatusDP";
            Column8.DataPropertyName = "StatusPenyewaan";

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                MenuKonteks.Show(dataGridView1, e.Location);
            }
        }

        private void UpdateStatusPenyewaan(string newStatus)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan pilih baris penyewaan terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Apakah Anda yakin ingin mengatur status penyewaan yang dipilih menjadi '{newStatus}'?",
                "Konfirmasi Perubahan Status",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        var selectedDataRow = row.DataBoundItem as dynamic;
                        int idPenyewaan = selectedDataRow.IdPenyewaan;

                        var penyewaanToUpdate = db.penyewaan.FirstOrDefault(p => p.id_penyewaan == idPenyewaan);

                        if (penyewaanToUpdate != null)
                        {
                            penyewaanToUpdate.status_peminjaman = newStatus;
                        }
                    }
                    db.SaveChanges();
                    MessageBox.Show($"Status penyewaan berhasil diupdate menjadi '{newStatus}'.", "Update Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRiwayatTransaksi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal mengupdate status: {ex.Message}", "Error Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void menuDisetujui_Click(object sender, EventArgs e)
        {
            UpdateStatusPenyewaan("Disetujui");
        }

        private void menuDitolak_Click(object sender, EventArgs e)
        {
            UpdateStatusPenyewaan("Ditolak");
        }

        public void ExportToPDF(DataGridView dataGridView)
        {
            try
            {
                Document document = new Document();
                Section section = document.AddSection();

                Paragraph title = section.AddParagraph("DETAIL PENYEWAAN");
                title.Format.Font.Size = 16;
                title.Format.Font.Bold = true;
                title.Format.Alignment = ParagraphAlignment.Center;
                title.AddSpace(1);

                Table table = section.AddTable();
                table.Borders.Width = 0.75;

                int visibleColumnCount = dataGridView.Columns.Cast<DataGridViewColumn>().Count(c => c.Visible);
                if (visibleColumnCount == 0)
                {
                    MessageBox.Show("Tidak ada kolom yang terlihat untuk diekspor ke PDF.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double totalWidth = section.PageSetup.PageWidth - section.PageSetup.LeftMargin - section.PageSetup.RightMargin;
                double defaultColumnWidth = totalWidth / visibleColumnCount;

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    if (column.Visible)
                    {
                        table.AddColumn(defaultColumnWidth);
                    }
                }

                Row headerRow = table.AddRow();
                headerRow.Shading.Color = new Color(63, 81, 181);
                headerRow.Format.Font.Color = Colors.White;
                headerRow.Format.Font.Bold = true;

                int colIndexPdf = 0;
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    if (dataGridView.Columns[i].Visible)
                    {
                        headerRow.Cells[colIndexPdf].AddParagraph(dataGridView.Columns[i].HeaderText);
                        headerRow.Cells[colIndexPdf].Format.Alignment = ParagraphAlignment.Center;
                        colIndexPdf++;
                    }
                }

                foreach (DataGridViewRow dgvRow in dataGridView.Rows)
                {
                    if (dgvRow.IsNewRow) continue;

                    Row dataRow = table.AddRow();
                    colIndexPdf = 0;
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        if (dataGridView.Columns[i].Visible)
                        {
                            string cellValue = dgvRow.Cells[i].Value?.ToString() ?? "";
                            dataRow.Cells[colIndexPdf].AddParagraph(cellValue);
                            dataRow.Cells[colIndexPdf].Format.Alignment = ParagraphAlignment.Center;

                            if (dgvRow.Index % 2 == 1)
                            {
                                dataRow.Cells[colIndexPdf].Shading.Color = Colors.LightGray;
                            }
                            colIndexPdf++;
                        }
                    }
                }

                section.PageSetup.LeftMargin = Unit.FromCentimeter(2);
                section.PageSetup.RightMargin = Unit.FromCentimeter(2);
                PdfDocumentRenderer renderer = new PdfDocumentRenderer();
                renderer.Document = document;
                renderer.RenderDocument();
                string folderPath = @"C:\Users\LENOVO\Desktop\Detail Penyewaan";

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string filePath = Path.Combine(folderPath, $"Transaksi_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");
                renderer.Save(filePath);

                MessageBox.Show($"PDF berhasil disimpan di:\n{filePath}", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportPDF_Click(object sender, EventArgs e)
        {
            ExportToPDF(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}