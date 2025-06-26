namespace debugging
{
    partial class Form_Penyewaan
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
            lblProduk = new Label();
            label3 = new Label();
            lblDp = new Label();
            label5 = new Label();
            lblAlamat = new Label();
            tanggalSewa = new DateTimePicker();
            tanggalKembali = new DateTimePicker();
            label2 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            lblNoRek = new Label();
            btnKembali = new Button();
            btnSewa = new Button();
            label7 = new Label();
            numericUpDownJumlah = new NumericUpDown();
            lblRek = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownJumlah).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 60);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Produk";
            // 
            // lblProduk
            // 
            lblProduk.AutoSize = true;
            lblProduk.Location = new Point(225, 60);
            lblProduk.Name = "lblProduk";
            lblProduk.Size = new Size(0, 20);
            lblProduk.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 141);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 2;
            label3.Text = "Dp";
            // 
            // lblDp
            // 
            lblDp.AutoSize = true;
            lblDp.Location = new Point(225, 141);
            lblDp.Name = "lblDp";
            lblDp.Size = new Size(0, 20);
            lblDp.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 190);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Alamat";
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(225, 190);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(0, 20);
            lblAlamat.TabIndex = 5;
            // 
            // tanggalSewa
            // 
            tanggalSewa.Location = new Point(225, 237);
            tanggalSewa.Name = "tanggalSewa";
            tanggalSewa.Size = new Size(250, 27);
            tanggalSewa.TabIndex = 6;
            // 
            // tanggalKembali
            // 
            tanggalKembali.Location = new Point(225, 293);
            tanggalKembali.Name = "tanggalKembali";
            tanggalKembali.Size = new Size(250, 27);
            tanggalKembali.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 237);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 8;
            label2.Text = "Tanggal Sewa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 293);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 9;
            label4.Text = "Tanggal Kembali";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(225, 344);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 347);
            label6.Name = "label6";
            label6.Size = new Size(146, 20);
            label6.TabIndex = 11;
            label6.Text = "Metode Pembayaran";
            // 
            // lblNoRek
            // 
            lblNoRek.AutoSize = true;
            lblNoRek.Location = new Point(395, 347);
            lblNoRek.Name = "lblNoRek";
            lblNoRek.Size = new Size(0, 20);
            lblNoRek.TabIndex = 12;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(494, 371);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(94, 29);
            btnKembali.TabIndex = 13;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnSewa
            // 
            btnSewa.Location = new Point(606, 371);
            btnSewa.Name = "btnSewa";
            btnSewa.Size = new Size(94, 29);
            btnSewa.TabIndex = 14;
            btnSewa.Text = "Sewa";
            btnSewa.UseVisualStyleBackColor = true;
            btnSewa.Click += btnSewa_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(73, 99);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 15;
            label7.Text = "Jumlah";
            // 
            // numericUpDownJumlah
            // 
            numericUpDownJumlah.Location = new Point(225, 97);
            numericUpDownJumlah.Name = "numericUpDownJumlah";
            numericUpDownJumlah.Size = new Size(41, 27);
            numericUpDownJumlah.TabIndex = 16;
            // 
            // lblRek
            // 
            lblRek.AutoSize = true;
            lblRek.Location = new Point(401, 347);
            lblRek.Name = "lblRek";
            lblRek.Size = new Size(0, 20);
            lblRek.TabIndex = 17;
            // 
            // Form_Penyewaan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 412);
            Controls.Add(lblRek);
            Controls.Add(numericUpDownJumlah);
            Controls.Add(label7);
            Controls.Add(btnSewa);
            Controls.Add(btnKembali);
            Controls.Add(lblNoRek);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(tanggalKembali);
            Controls.Add(tanggalSewa);
            Controls.Add(lblAlamat);
            Controls.Add(label5);
            Controls.Add(lblDp);
            Controls.Add(label3);
            Controls.Add(lblProduk);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form_Penyewaan";
            Text = "formangkag";
            ((System.ComponentModel.ISupportInitialize)numericUpDownJumlah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblProduk;
        private Label label3;
        private Label lblDp;
        private Label label5;
        private Label lblAlamat;
        private DateTimePicker tanggalSewa;
        private DateTimePicker tanggalKembali;
        private Label label2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label6;
        private Label lblNoRek;
        private Button btnKembali;
        private Button btnSewa;
        private Label label7;
        private NumericUpDown numericUpDownJumlah;
        private Label lblRek;
    }
}