namespace debugging
{
    partial class Riwayat_Transaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Riwayat_Transaksi));
            label1 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            BtnExportPDF = new Button();
            button2 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(554, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(251, 41);
            label1.TabIndex = 0;
            label1.Text = "Detail Penyewaan\r\n";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(39, 100);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 33);
            comboBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(39, 142);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1275, 584);
            dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(39, 11);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(60, 55);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            // 
            // BtnExportPDF
            // 
            BtnExportPDF.BackColor = Color.WhiteSmoke;
            BtnExportPDF.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnExportPDF.Location = new Point(1154, 732);
            BtnExportPDF.Margin = new Padding(4);
            BtnExportPDF.Name = "BtnExportPDF";
            BtnExportPDF.Size = new Size(160, 36);
            BtnExportPDF.TabIndex = 5;
            BtnExportPDF.Text = "Convert Ke PDF";
            BtnExportPDF.UseVisualStyleBackColor = false;
            BtnExportPDF.Click += ExportPDF_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.Control;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1311, -1);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(41, 36);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 42;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama Penyewa";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 130;
            // 
            // Column3
            // 
            Column3.HeaderText = "Produk";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 130;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tanggal Penyewaan";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 130;
            // 
            // Column5
            // 
            Column5.HeaderText = "Batas Penyewaan";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 130;
            // 
            // Column6
            // 
            Column6.HeaderText = "Nominal DP";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 130;
            // 
            // Column7
            // 
            Column7.HeaderText = "Status Dp";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 130;
            // 
            // Column8
            // 
            Column8.HeaderText = "Status Penyewaan";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 130;
            // 
            // Riwayat_Transaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(149, 175, 192);
            ClientSize = new Size(1352, 784);
            Controls.Add(button2);
            Controls.Add(BtnExportPDF);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Riwayat_Transaksi";
            Text = "Statuss_Penyewaan";
            Load += Riwayat_Transaksi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button BtnExportPDF;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}