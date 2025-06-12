namespace debugging
{
    partial class Kelola_Product
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kelola_Product));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNama = new TextBox();
            txtStok = new TextBox();
            txtHarga = new TextBox();
            txtDeskripsi = new TextBox();
            btnTambah = new Button();
            btnUpdate = new Button();
            btnHapus = new Button();
            label6 = new Label();
            txtID = new TextBox();
            BtnExportPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Enabled = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(96, 416);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1150, 312);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(541, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(328, 33);
            label1.TabIndex = 0;
            label1.Text = "MANAJEMENT PRODUCT";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(494, 5);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(119, 94);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 3;
            label2.Text = "ID_Produk       :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(115, 204);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 25);
            label3.TabIndex = 4;
            label3.Text = "Stok                 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(116, 265);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 25);
            label4.TabIndex = 5;
            label4.Text = "Harga              :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(115, 331);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 6;
            label5.Text = "Deskripsi        :";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(250, 144);
            txtNama.Margin = new Padding(4, 4, 4, 4);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(995, 31);
            txtNama.TabIndex = 7;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(249, 204);
            txtStok.Margin = new Padding(4, 4, 4, 4);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(996, 31);
            txtStok.TabIndex = 8;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(250, 265);
            txtHarga.Margin = new Padding(4, 4, 4, 4);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(995, 31);
            txtHarga.TabIndex = 9;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(246, 331);
            txtDeskripsi.Margin = new Padding(4, 4, 4, 4);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(999, 31);
            txtDeskripsi.TabIndex = 10;
            txtDeskripsi.TextChanged += txtDeskripsi_TextChanged;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.SeaGreen;
            btnTambah.Location = new Point(331, 372);
            btnTambah.Margin = new Padding(4, 4, 4, 4);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(118, 36);
            btnTambah.TabIndex = 11;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkCyan;
            btnUpdate.ForeColor = SystemColors.ControlText;
            btnUpdate.Location = new Point(501, 372);
            btnUpdate.Margin = new Padding(4, 4, 4, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 36);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(255, 52, 52);
            btnHapus.Location = new Point(672, 372);
            btnHapus.Margin = new Padding(4, 4, 4, 4);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(118, 36);
            btnHapus.TabIndex = 13;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(116, 144);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 14;
            label6.Text = "Nama Produk :";
            // 
            // txtID
            // 
            txtID.Location = new Point(250, 94);
            txtID.Margin = new Padding(4, 4, 4, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(995, 31);
            txtID.TabIndex = 15;
            // 
            // BtnExportPDF
            // 
            BtnExportPDF.BackColor = Color.WhiteSmoke;
            BtnExportPDF.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnExportPDF.Location = new Point(1086, 736);
            BtnExportPDF.Margin = new Padding(4, 4, 4, 4);
            BtnExportPDF.Name = "BtnExportPDF";
            BtnExportPDF.Size = new Size(160, 36);
            BtnExportPDF.TabIndex = 16;
            BtnExportPDF.Text = "Convert Ke PDF";
            BtnExportPDF.UseVisualStyleBackColor = false;
            // 
            // Kelola_Product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 102);
            ClientSize = new Size(1352, 784);
            Controls.Add(BtnExportPDF);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(btnHapus);
            Controls.Add(btnUpdate);
            Controls.Add(btnTambah);
            Controls.Add(txtDeskripsi);
            Controls.Add(txtHarga);
            Controls.Add(txtStok);
            Controls.Add(txtNama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Kelola_Product";
            Text = "Kelola_Product";
            Load += Kelola_Product_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNama;
        private TextBox txtStok;
        private TextBox txtHarga;
        private TextBox txtDeskripsi;
        private Button btnTambah;
        private Button btnUpdate;
        private Button btnHapus;
        private Label label6;
        private TextBox txtID;
        private Button BtnExportPDF;
    }
}
