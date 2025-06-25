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
            tampilkan_id_grid.Location = new Point(119, 122);
            tampilkan_id_grid.Name = "tampilkan_id_grid";
            tampilkan_id_grid.RowHeadersWidth = 51;
            tampilkan_id_grid.Size = new Size(526, 61);
            tampilkan_id_grid.TabIndex = 0;
            // 
            // Cari_id
            // 
            Cari_id.AutoSize = true;
            Cari_id.Location = new Point(95, 77);
            Cari_id.Name = "Cari_id";
            Cari_id.Size = new Size(54, 20);
            Cari_id.TabIndex = 1;
            Cari_id.Text = "Cari ID";
            // 
            // button1
            // 
            button1.Location = new Point(662, 15);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Update ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblCari_id
            // 
            lblCari_id.Location = new Point(174, 77);
            lblCari_id.Name = "lblCari_id";
            lblCari_id.Size = new Size(66, 27);
            lblCari_id.TabIndex = 3;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(267, 77);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(38, 27);
            btn_ok.TabIndex = 4;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // comboBoxkategori
            // 
            comboBoxkategori.FormattingEnabled = true;
            comboBoxkategori.Items.AddRange(new object[] { "Harga", "Stok", "Kategori" });
            comboBoxkategori.Location = new Point(129, 189);
            comboBoxkategori.Name = "comboBoxkategori";
            comboBoxkategori.Size = new Size(160, 28);
            comboBoxkategori.TabIndex = 6;
            // 
            // textBoxUpdateValue
            // 
            textBoxUpdateValue.Location = new Point(129, 262);
            textBoxUpdateValue.Name = "textBoxUpdateValue";
            textBoxUpdateValue.Size = new Size(340, 27);
            textBoxUpdateValue.TabIndex = 13;
            textBoxUpdateValue.TextChanged += textBoxUpdateValue_TextChanged;
            // 
            // comboBoxKategoriUpdate
            // 
            comboBoxKategoriUpdate.FormattingEnabled = true;
            comboBoxKategoriUpdate.Location = new Point(129, 294);
            comboBoxKategoriUpdate.Name = "comboBoxKategoriUpdate";
            comboBoxKategoriUpdate.Size = new Size(340, 28);
            comboBoxKategoriUpdate.TabIndex = 14;
            comboBoxKategoriUpdate.SelectedIndexChanged += comboBoxKategoriUpdate_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 33, 36);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Coral;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 59);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 33, 36);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 350);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 54);
            panel2.TabIndex = 16;
            // 
            // update_Produk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 404);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(comboBoxKategoriUpdate);
            Controls.Add(textBoxUpdateValue);
            Controls.Add(comboBoxkategori);
            Controls.Add(btn_ok);
            Controls.Add(lblCari_id);
            Controls.Add(Cari_id);
            Controls.Add(tampilkan_id_grid);
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