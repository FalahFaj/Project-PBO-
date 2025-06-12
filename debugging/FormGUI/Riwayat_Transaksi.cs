using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Forms;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using Color = MigraDoc.DocumentObjectModel.Color;
using Font = MigraDoc.DocumentObjectModel.Font;

namespace debugging
{
    [NotMapped]
    public partial class Riwayat_Transaksi : Form
    {
        public Riwayat_Transaksi()
        {
            InitializeComponent();

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

            comboBox1.Items.Add("Semua");
            comboBox1.Items.Add("Beli");
            comboBox1.Items.Add("Sewa");
            comboBox1.SelectedIndex = 0;
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

                Table table = section.AddTable();

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    table.AddColumn();
                }

                Row headerRow = table.AddRow();
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    headerRow.Cells[i].AddParagraph(dataGridView.Columns[i].HeaderText);
                    headerRow.Cells[i].Shading.Color = Colors.LightBlue;
                    headerRow.Cells[i].Format.Font.Bold = true;
                }

                foreach (DataGridViewRow dgvRow in dataGridView.Rows)
                {
                    if (dgvRow.IsNewRow) continue;

                    Row dataRow = table.AddRow();
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        dataRow.Cells[i].AddParagraph(dgvRow.Cells[i].Value?.ToString() ?? "");
                        if (dgvRow.Index % 2 == 1)
                        {
                            dataRow.Cells[i].Shading.Color = Colors.LightGray;
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