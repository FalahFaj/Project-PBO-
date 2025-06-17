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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            BtnExportPDF = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            txtCariID = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(443, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 35);
            label1.TabIndex = 0;
            label1.Text = "Detail Penyewaan\r\n";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(31, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(31, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1020, 467);
            dataGridView1.TabIndex = 2;
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
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(31, 9);
            button1.Name = "button1";
            button1.Size = new Size(48, 44);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            // 
            // BtnExportPDF
            // 
            BtnExportPDF.BackColor = Color.WhiteSmoke;
            BtnExportPDF.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnExportPDF.Location = new Point(923, 586);
            BtnExportPDF.Name = "BtnExportPDF";
            BtnExportPDF.Size = new Size(128, 29);
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
            button2.Location = new Point(1049, -1);
            button2.Name = "button2";
            button2.Size = new Size(33, 29);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(215, 586);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtCariID
            // 
            txtCariID.AutoSize = true;
            txtCariID.Location = new Point(39, 589);
            txtCariID.Name = "txtCariID";
            txtCariID.Size = new Size(170, 20);
            txtCariID.TabIndex = 9;
            txtCariID.Text = "Masukkan ID Penyewaan";
            // 
            // button4
            // 
            button4.Location = new Point(346, 584);
            button4.Name = "button4";
            button4.Size = new Size(43, 29);
            button4.TabIndex = 10;
            button4.Text = "OK";
            button4.UseVisualStyleBackColor = true;
            button4.EnabledChanged += button4_Click;
            button4.Click += button4_Click;
            // 
            // Riwayat_Transaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(149, 175, 192);
            ClientSize = new Size(1082, 627);
            Controls.Add(button4);
            Controls.Add(txtCariID);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(BtnExportPDF);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox textBox1;
        private Button button3;
        private Label label2;
        private Label txtCariID;
        private Button button4;
    }
}