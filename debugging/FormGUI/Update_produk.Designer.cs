namespace debugging
{
    partial class update_Produk
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
            tampilkan_id_grid = new DataGridView();
            Cari_id = new Label();
            button1 = new Button();
            lblCari_id = new TextBox();
            btn_ok = new Button();
            comboBoxkategori = new ComboBox();
            textBoxUpdateValue = new TextBox();
            comboBoxKategoriUpdate = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)tampilkan_id_grid).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tampilkan_id_grid
            // 
            tampilkan_id_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tampilkan_id_grid.Location = new Point(149, 152);
            tampilkan_id_grid.Margin = new Padding(4, 4, 4, 4);
            tampilkan_id_grid.Name = "tampilkan_id_grid";
            tampilkan_id_grid.RowHeadersWidth = 51;
            tampilkan_id_grid.Size = new Size(658, 42);
            tampilkan_id_grid.TabIndex = 0;
            // 
            // Cari_id
            // 
            Cari_id.AutoSize = true;
            Cari_id.Location = new Point(119, 96);
            Cari_id.Margin = new Padding(4, 0, 4, 0);
            Cari_id.Name = "Cari_id";
            Cari_id.Size = new Size(65, 25);
            Cari_id.TabIndex = 1;
            Cari_id.Text = "Cari ID";
            // 
            // button1
            // 
            button1.Location = new Point(828, 19);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 2;
            button1.Text = "Update ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblCari_id
            // 
            lblCari_id.Location = new Point(218, 96);
            lblCari_id.Margin = new Padding(4, 4, 4, 4);
            lblCari_id.Name = "lblCari_id";
            lblCari_id.Size = new Size(82, 31);
            lblCari_id.TabIndex = 3;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(334, 96);
            btn_ok.Margin = new Padding(4, 4, 4, 4);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(48, 34);
            btn_ok.TabIndex = 4;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // comboBoxkategori
            // 
            comboBoxkategori.FormattingEnabled = true;
            comboBoxkategori.Items.AddRange(new object[] { "Harga", "Stok", "Kategori" });
            comboBoxkategori.Location = new Point(218, 202);
            comboBoxkategori.Margin = new Padding(4, 4, 4, 4);
            comboBoxkategori.Name = "comboBoxkategori";
            comboBoxkategori.Size = new Size(199, 33);
            comboBoxkategori.TabIndex = 6;
            // 
            // textBoxUpdateValue
            // 
            textBoxUpdateValue.Location = new Point(161, 327);
            textBoxUpdateValue.Margin = new Padding(4, 4, 4, 4);
            textBoxUpdateValue.Name = "textBoxUpdateValue";
            textBoxUpdateValue.Size = new Size(424, 31);
            textBoxUpdateValue.TabIndex = 13;
            // 
            // comboBoxKategoriUpdate
            // 
            comboBoxKategoriUpdate.FormattingEnabled = true;
            comboBoxKategoriUpdate.Location = new Point(161, 368);
            comboBoxKategoriUpdate.Margin = new Padding(4, 4, 4, 4);
            comboBoxKategoriUpdate.Name = "comboBoxKategoriUpdate";
            comboBoxKategoriUpdate.Size = new Size(424, 33);
            comboBoxKategoriUpdate.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 33, 36);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Coral;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 74);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 33, 36);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 437);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 68);
            panel2.TabIndex = 16;
            // 
            // update_Produk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 505);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(comboBoxKategoriUpdate);
            Controls.Add(textBoxUpdateValue);
            Controls.Add(comboBoxkategori);
            Controls.Add(btn_ok);
            Controls.Add(lblCari_id);
            Controls.Add(Cari_id);
            Controls.Add(tampilkan_id_grid);
            Margin = new Padding(4, 4, 4, 4);
            Name = "update_Produk";
            Text = "update_Produk";
            Load += update_Produk_Load;
            ((System.ComponentModel.ISupportInitialize)tampilkan_id_grid).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tampilkan_id_grid;
        private Label Cari_id;
        private Button button1;
        private TextBox lblCari_id;
        private Button btn_ok;
        private Label label_harga;
        private ComboBox comboBoxkategori;
        private Label label3;
        private TextBox text_nama;
        private TextBox text;
        private TextBox textBox4;
        private Label label_nama;
        private TextBox textBoxUpdateValue;
        private ComboBox comboBoxKategoriUpdate;
        private Label id_kategori;
        private Panel panel1;
        private Panel panel2;
    }
}