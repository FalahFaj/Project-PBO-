namespace debugging.FormGUI
{
    partial class Tambah_produk
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            boxNamaProduk = new TextBox();
            boxHarga = new TextBox();
            boxStok = new TextBox();
            btnSimpan = new Button();
            comboKategori = new ComboBox();
            comboDisewakan = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 78);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 126);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 176);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "Stok";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 235);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 3;
            label4.Text = "Kategori";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 295);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 4;
            label5.Text = "Disewakan";
            // 
            // boxNamaProduk
            // 
            boxNamaProduk.Location = new Point(324, 78);
            boxNamaProduk.Name = "boxNamaProduk";
            boxNamaProduk.Size = new Size(246, 27);
            boxNamaProduk.TabIndex = 6;
            // 
            // boxHarga
            // 
            boxHarga.Location = new Point(324, 126);
            boxHarga.Name = "boxHarga";
            boxHarga.Size = new Size(246, 27);
            boxHarga.TabIndex = 7;
            // 
            // boxStok
            // 
            boxStok.Location = new Point(324, 173);
            boxStok.Name = "boxStok";
            boxStok.Size = new Size(246, 27);
            boxStok.TabIndex = 8;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(612, 397);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 11;
            btnSimpan.Text = "simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // comboKategori
            // 
            comboKategori.FormattingEnabled = true;
            comboKategori.Location = new Point(324, 227);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(246, 28);
            comboKategori.TabIndex = 12;
            // 
            // comboDisewakan
            // 
            comboDisewakan.FormattingEnabled = true;
            comboDisewakan.Location = new Point(324, 287);
            comboDisewakan.Name = "comboDisewakan";
            comboDisewakan.Size = new Size(246, 28);
            comboDisewakan.TabIndex = 13;
            // 
            // Tambah_produk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboDisewakan);
            Controls.Add(comboKategori);
            Controls.Add(btnSimpan);
            Controls.Add(boxStok);
            Controls.Add(boxHarga);
            Controls.Add(boxNamaProduk);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Tambah_produk";
            Text = "Tambah_produk";
            Load += Tambah_produk_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox boxNamaProduk;
        private TextBox boxHarga;
        private TextBox textBox2;
        private TextBox boxStok;
        private Button btnSimpan;
        private ComboBox comboKategori;
        private ComboBox comboDisewakan;
    }
}