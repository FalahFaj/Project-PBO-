namespace debugging.FormGUI
{
    partial class BarangSewa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picProdukDisewa = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNamaProduk = new Label();
            txtTglSewa = new Label();
            txtTglJatuhTempo = new Label();
            txtStatus = new Label();
            txtDenda = new Label();
            label6 = new Label();
            btnKembalikan = new Button();
            ((System.ComponentModel.ISupportInitialize)picProdukDisewa).BeginInit();
            SuspendLayout();
            // 
            // picProdukDisewa
            // 
            picProdukDisewa.Location = new Point(26, 25);
            picProdukDisewa.Name = "picProdukDisewa";
            picProdukDisewa.Size = new Size(133, 125);
            picProdukDisewa.SizeMode = PictureBoxSizeMode.Zoom;
            picProdukDisewa.TabIndex = 0;
            picProdukDisewa.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 25);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "Nama Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 57);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 2;
            label2.Text = "Tgl Sewa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 94);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 3;
            label3.Text = "Tgl Jatuh Tempo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 130);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 4;
            label4.Text = "Status";
            // 
            // txtNamaProduk
            // 
            txtNamaProduk.AutoSize = true;
            txtNamaProduk.Location = new Point(327, 25);
            txtNamaProduk.Name = "txtNamaProduk";
            txtNamaProduk.Size = new Size(50, 20);
            txtNamaProduk.TabIndex = 5;
            txtNamaProduk.Text = "label5";
            // 
            // txtTglSewa
            // 
            txtTglSewa.AutoSize = true;
            txtTglSewa.Location = new Point(327, 57);
            txtTglSewa.Name = "txtTglSewa";
            txtTglSewa.Size = new Size(50, 20);
            txtTglSewa.TabIndex = 6;
            txtTglSewa.Text = "label6";
            // 
            // txtTglJatuhTempo
            // 
            txtTglJatuhTempo.AutoSize = true;
            txtTglJatuhTempo.Location = new Point(327, 94);
            txtTglJatuhTempo.Name = "txtTglJatuhTempo";
            txtTglJatuhTempo.Size = new Size(50, 20);
            txtTglJatuhTempo.TabIndex = 7;
            txtTglJatuhTempo.Text = "label7";
            // 
            // txtStatus
            // 
            txtStatus.AutoSize = true;
            txtStatus.Location = new Point(327, 130);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(50, 20);
            txtStatus.TabIndex = 8;
            txtStatus.Text = "label8";
            // 
            // txtDenda
            // 
            txtDenda.AutoSize = true;
            txtDenda.Location = new Point(327, 166);
            txtDenda.Name = "txtDenda";
            txtDenda.Size = new Size(50, 20);
            txtDenda.TabIndex = 10;
            txtDenda.Text = "label8";
            txtDenda.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(186, 166);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 9;
            label6.Text = "Denda";
            label6.Visible = false;
            // 
            // btnKembalikan
            // 
            btnKembalikan.Location = new Point(345, 199);
            btnKembalikan.Name = "btnKembalikan";
            btnKembalikan.Size = new Size(102, 29);
            btnKembalikan.TabIndex = 11;
            btnKembalikan.Text = "Kembalikan";
            btnKembalikan.UseVisualStyleBackColor = true;
            btnKembalikan.Click += btnKembalikan_Click;
            // 
            // BarangSewa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnKembalikan);
            Controls.Add(txtDenda);
            Controls.Add(label6);
            Controls.Add(txtStatus);
            Controls.Add(txtTglJatuhTempo);
            Controls.Add(txtTglSewa);
            Controls.Add(txtNamaProduk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picProdukDisewa);
            Name = "BarangSewa";
            Size = new Size(459, 240);
            ((System.ComponentModel.ISupportInitialize)picProdukDisewa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picProdukDisewa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label txtNamaProduk;
        private Label txtTglSewa;
        private Label txtTglJatuhTempo;
        private Label txtStatus;
        private Label txtDenda;
        private Label label6;
        private Button btnKembalikan;
    }
}
