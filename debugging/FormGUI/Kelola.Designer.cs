namespace debugging
{
    partial class Kelola
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
            Id = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnTambah = new Button();
            btnUpdate = new Button();
            btnHapus = new Button();
            grid_Produk = new DataGridView();
            txtId = new TextBox();
            btn_hapus = new Button();
            ((System.ComponentModel.ISupportInitialize)grid_Produk).BeginInit();
            SuspendLayout();
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
            Nama.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Stok";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Harga";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Disewakan";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(1, 309);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(101, 309);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(201, 309);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 3;
            btnHapus.Text = "Delete";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // grid_Produk
            // 
            grid_Produk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_Produk.Location = new Point(1, 0);
            grid_Produk.Name = "grid_Produk";
            grid_Produk.RowHeadersWidth = 51;
            grid_Produk.Size = new Size(678, 277);
            grid_Produk.TabIndex = 4;
            grid_Produk.CellContentClick += grid_Produk_CellContentClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(319, 311);
            txtId.Name = "txtId";
            txtId.Size = new Size(44, 27);
            txtId.TabIndex = 5;
            // 
            // btn_hapus
            // 
            btn_hapus.Location = new Point(382, 311);
            btn_hapus.Name = "btn_hapus";
            btn_hapus.Size = new Size(67, 29);
            btn_hapus.TabIndex = 6;
            btn_hapus.Text = "hapus";
            btn_hapus.UseVisualStyleBackColor = true;
            // 
            // Kelola
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(679, 341);
            Controls.Add(btn_hapus);
            Controls.Add(txtId);
            Controls.Add(grid_Produk);
            Controls.Add(btnHapus);
            Controls.Add(btnUpdate);
            Controls.Add(btnTambah);
            Name = "Kelola";
            Text = "Kelola";
            ((System.ComponentModel.ISupportInitialize)grid_Produk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnTambah;
        private Button btnUpdate;
        private Button btnHapus;
        private DataGridView grid_Produk;
        private TextBox txtId;
        private Button btn_hapus;
    }
}