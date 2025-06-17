namespace debugging
{
    partial class Produk_di_Keranjang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produk_di_Keranjang));
            fotoProduk = new PictureBox();
            lblNama = new Label();
            lblHarga = new Label();
            lblJumlah = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)fotoProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // fotoProduk
            // 
            fotoProduk.Location = new Point(26, 21);
            fotoProduk.Margin = new Padding(2);
            fotoProduk.Name = "fotoProduk";
            fotoProduk.Size = new Size(191, 146);
            fotoProduk.SizeMode = PictureBoxSizeMode.Zoom;
            fotoProduk.TabIndex = 0;
            fotoProduk.TabStop = false;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(399, 38);
            lblNama.Margin = new Padding(2, 0, 2, 0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(0, 25);
            lblNama.TabIndex = 1;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(399, 86);
            lblHarga.Margin = new Padding(2, 0, 2, 0);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(0, 25);
            lblHarga.TabIndex = 2;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Location = new Point(399, 138);
            lblJumlah.Margin = new Padding(2, 0, 2, 0);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(0, 25);
            lblJumlah.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 38);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 4;
            label1.Text = "Nama Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 86);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 5;
            label2.Text = "Jumlah";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 138);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 6;
            label3.Text = "Keterangan";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.WhiteSmoke;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(361, 29);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(239, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(361, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(361, 131);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(239, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Produk_di_Keranjang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(lblJumlah);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(lblHarga);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblNama);
            Controls.Add(pictureBox4);
            Controls.Add(fotoProduk);
            Margin = new Padding(2);
            Name = "Produk_di_Keranjang";
            Size = new Size(625, 196);
            Load += Produk_di_Keranjang_Load_1;
            ((System.ComponentModel.ISupportInitialize)fotoProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox fotoProduk;
        private Label lblNama;
        private Label lblHarga;
        private Label lblJumlah;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
