namespace debugging
{
    partial class Pembayaran
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
            components = new System.ComponentModel.Container();
            Panel panel4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pembayaran));
            Panel panel2;
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            SidebarTimer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            SidebarContainer = new FlowLayoutPanel();
            GridViewProduk = new DataGridView();
            kolomBarang = new DataGridViewTextBoxColumn();
            kolomHarga = new DataGridViewTextBoxColumn();
            kolomJumlah = new DataGridViewTextBoxColumn();
            btnBeli = new Button();
            comboBox1 = new ComboBox();
            lblNorek = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblProduk = new Label();
            lblHarga = new Label();
            label5 = new Label();
            lblTotal = new Label();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            panel4 = new Panel();
            panel2 = new Panel();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SidebarContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox3);
            panel4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.ForeColor = Color.Transparent;
            panel4.Location = new Point(2, 131);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(223, 44);
            panel4.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(30, 40, 45);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(17, 9);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(18, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(2, 83);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 44);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(30, 40, 45);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 8);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SidebarTimer
            // 
            SidebarTimer.Interval = 10;
            SidebarTimer.Tick += SidebarTimer_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(373, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(201, 29);
            label2.TabIndex = 2;
            label2.Text = "Payment Details";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox5);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 77);
            panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(30, 40, 45);
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(18, 20);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(18, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click_1;
            // 
            // SidebarContainer
            // 
            SidebarContainer.BackColor = Color.FromArgb(35, 40, 45);
            SidebarContainer.Controls.Add(panel1);
            SidebarContainer.Controls.Add(panel2);
            SidebarContainer.Controls.Add(panel4);
            SidebarContainer.Dock = DockStyle.Left;
            SidebarContainer.Location = new Point(0, 0);
            SidebarContainer.Margin = new Padding(2);
            SidebarContainer.MaximumSize = new Size(226, 480);
            SidebarContainer.MinimumSize = new Size(57, 480);
            SidebarContainer.Name = "SidebarContainer";
            SidebarContainer.Size = new Size(57, 480);
            SidebarContainer.TabIndex = 1;
            // 
            // GridViewProduk
            // 
            GridViewProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewProduk.Columns.AddRange(new DataGridViewColumn[] { kolomBarang, kolomHarga, kolomJumlah });
            GridViewProduk.Location = new Point(119, 72);
            GridViewProduk.Margin = new Padding(2);
            GridViewProduk.Name = "GridViewProduk";
            GridViewProduk.RowHeadersWidth = 62;
            GridViewProduk.Size = new Size(710, 170);
            GridViewProduk.TabIndex = 10;
            GridViewProduk.CellContentClick += dataGridView1_CellContentClick;
            // 
            // kolomBarang
            // 
            kolomBarang.HeaderText = "Produk";
            kolomBarang.MinimumWidth = 8;
            kolomBarang.Name = "kolomBarang";
            kolomBarang.ReadOnly = true;
            kolomBarang.Width = 150;
            // 
            // kolomHarga
            // 
            kolomHarga.HeaderText = "Harga";
            kolomHarga.MinimumWidth = 8;
            kolomHarga.Name = "kolomHarga";
            kolomHarga.Width = 150;
            // 
            // kolomJumlah
            // 
            kolomJumlah.HeaderText = "Jumlah";
            kolomJumlah.MinimumWidth = 6;
            kolomJumlah.Name = "kolomJumlah";
            kolomJumlah.Width = 125;
            // 
            // btnBeli
            // 
            btnBeli.Location = new Point(683, 425);
            btnBeli.Margin = new Padding(2);
            btnBeli.Name = "btnBeli";
            btnBeli.Size = new Size(146, 35);
            btnBeli.TabIndex = 13;
            btnBeli.Text = "Bayar";
            btnBeli.UseVisualStyleBackColor = true;
            btnBeli.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bank BRI", "Bank BCA", "Shopee Pay", "Dana", "Cash" });
            comboBox1.Location = new Point(119, 305);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblNorek
            // 
            lblNorek.AutoSize = true;
            lblNorek.Location = new Point(322, 313);
            lblNorek.Name = "lblNorek";
            lblNorek.Size = new Size(0, 20);
            lblNorek.TabIndex = 15;
            lblNorek.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 282);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 16;
            label1.Text = "Metode Pembayaran";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 91);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 17;
            label3.Text = "Produk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 165);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 18;
            label4.Text = "Harga";
            // 
            // lblProduk
            // 
            lblProduk.AutoSize = true;
            lblProduk.Location = new Point(272, 91);
            lblProduk.Name = "lblProduk";
            lblProduk.Size = new Size(0, 20);
            lblProduk.TabIndex = 19;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(272, 167);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(0, 20);
            lblHarga.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 355);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 21;
            label5.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(194, 355);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(172, 129);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 23;
            label6.Text = "Jumlah";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(272, 127);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(65, 27);
            numericUpDown1.TabIndex = 24;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Pembayaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(880, 480);
            Controls.Add(GridViewProduk);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(lblTotal);
            Controls.Add(label5);
            Controls.Add(lblHarga);
            Controls.Add(lblProduk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblNorek);
            Controls.Add(comboBox1);
            Controls.Add(btnBeli);
            Controls.Add(label2);
            Controls.Add(SidebarContainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Pembayaran";
            Text = " ";
            Load += Pembayaran_Load;
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            SidebarContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridViewProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer SidebarTimer;
        private Label label2;
        private Label lblBeli;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox5;
        internal FlowLayoutPanel SidebarContainer;
        private DataGridView GridViewProduk;
        private Button btnBeli;
        private DataGridViewTextBoxColumn kolomBarang;
        private DataGridViewTextBoxColumn kolomHarga;
        private DataGridViewTextBoxColumn kolomJumlah;
        private ComboBox comboBox1;
        private Label lblNorek;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label lblProduk;
        private Label lblHarga;
        private Label label5;
        private Label lblTotal;
        private Label label6;
        private NumericUpDown numericUpDown1;
    }
}