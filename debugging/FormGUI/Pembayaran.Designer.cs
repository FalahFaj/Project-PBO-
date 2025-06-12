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
            Panel panel3;
            Panel panel2;
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            SidebarTimer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            SidebarContainer = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            Beli = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SidebarContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox3);
            panel4.Font = new Font("Poppins ExtraLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.ForeColor = Color.Transparent;
            panel4.Location = new Point(3, 227);
            panel4.Name = "panel4";
            panel4.Size = new Size(279, 55);
            panel4.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(30, 40, 45);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(21, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Font = new Font("Poppins ExtraLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.ForeColor = Color.Transparent;
            panel3.Location = new Point(3, 166);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 55);
            panel3.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(30, 40, 45);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Font = new Font("Poppins ExtraLight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(3, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 55);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(30, 40, 45);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 25);
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
            label2.Font = new Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(466, 28);
            label2.Name = "label2";
            label2.Size = new Size(258, 49);
            label2.TabIndex = 2;
            label2.Text = "Payment Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(759, 80);
            label3.Name = "label3";
            label3.Size = new Size(56, 32);
            label3.TabIndex = 5;
            label3.Text = "Rent";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(318, 80);
            label4.Name = "label4";
            label4.Size = new Size(101, 32);
            label4.TabIndex = 6;
            label4.Text = "Purchase";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox5);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 96);
            panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(30, 40, 45);
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(23, 25);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(23, 25);
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
            SidebarContainer.Controls.Add(panel3);
            SidebarContainer.Controls.Add(panel4);
            SidebarContainer.Dock = DockStyle.Left;
            SidebarContainer.Location = new Point(0, 0);
            SidebarContainer.MaximumSize = new Size(282, 600);
            SidebarContainer.MinimumSize = new Size(71, 600);
            SidebarContainer.Name = "SidebarContainer";
            SidebarContainer.Size = new Size(71, 600);
            SidebarContainer.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Beli, Harga });
            dataGridView1.Location = new Point(193, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 10;
            // 
            // Beli
            // 
            Beli.HeaderText = "Beli";
            Beli.MinimumWidth = 8;
            Beli.Name = "Beli";
            Beli.Width = 150;
            // 
            // Harga
            // 
            Harga.HeaderText = "Harga";
            Harga.MinimumWidth = 8;
            Harga.Name = "Harga";
            Harga.Width = 150;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridView2.Location = new Point(604, 115);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(360, 225);
            dataGridView2.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Beli";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Harga";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(604, 346);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(736, 459);
            button1.Name = "button1";
            button1.Size = new Size(228, 83);
            button1.TabIndex = 13;
            button1.Text = "Accept";
            button1.UseVisualStyleBackColor = true;
            // 
            // Pembayaran
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 600);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SidebarContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pembayaran";
            Text = " ";
            Load += Pembayaran_Load;
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            SidebarContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer SidebarTimer;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox5;
        internal FlowLayoutPanel SidebarContainer;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Beli;
        private DataGridViewTextBoxColumn Harga;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}