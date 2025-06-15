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
            fotoProduk = new PictureBox();
            lblNama = new Label();
            lblHarga = new Label();
            lblJumlah = new Label();
            ((System.ComponentModel.ISupportInitialize)fotoProduk).BeginInit();
            SuspendLayout();
            // 
            // fotoProduk
            // 
            fotoProduk.Location = new Point(21, 17);
            fotoProduk.Margin = new Padding(2);
            fotoProduk.Name = "fotoProduk";
            fotoProduk.Size = new Size(153, 117);
            fotoProduk.SizeMode = PictureBoxSizeMode.Zoom;
            fotoProduk.TabIndex = 0;
            fotoProduk.TabStop = false;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(319, 30);
            lblNama.Margin = new Padding(2, 0, 2, 0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(0, 20);
            lblNama.TabIndex = 1;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(319, 69);
            lblHarga.Margin = new Padding(2, 0, 2, 0);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(0, 20);
            lblHarga.TabIndex = 2;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Location = new Point(319, 110);
            lblJumlah.Margin = new Padding(2, 0, 2, 0);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(0, 20);
            lblJumlah.TabIndex = 3;
            // 
            // Produk_di_Keranjang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblJumlah);
            Controls.Add(lblHarga);
            Controls.Add(lblNama);
            Controls.Add(fotoProduk);
            Margin = new Padding(2);
            Name = "Produk_di_Keranjang";
            Size = new Size(500, 157);
            ((System.ComponentModel.ISupportInitialize)fotoProduk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox fotoProduk;
        private Label lblNama;
        private Label lblHarga;
        private Label lblJumlah;
    }
}
