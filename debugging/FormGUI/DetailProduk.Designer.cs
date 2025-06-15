namespace debugging.FormGUI
{
    partial class DetailProduk
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnKeranjang = new Button();
            btnBeli = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(35, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 77);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 117);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 159);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 3;
            label3.Text = "deskripsi";
            // 
            // btnKeranjang
            // 
            btnKeranjang.BackColor = Color.FromArgb(32, 33, 36);
            btnKeranjang.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKeranjang.ForeColor = Color.White;
            btnKeranjang.Location = new Point(328, 246);
            btnKeranjang.Margin = new Padding(2);
            btnKeranjang.Name = "btnKeranjang";
            btnKeranjang.Size = new Size(138, 48);
            btnKeranjang.TabIndex = 4;
            btnKeranjang.Text = "keranjang";
            btnKeranjang.UseVisualStyleBackColor = false;
            btnKeranjang.Click += btnKeranjang_Click;
            // 
            // btnBeli
            // 
            btnBeli.BackColor = Color.FromArgb(32, 33, 36);
            btnBeli.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBeli.ForeColor = Color.White;
            btnBeli.Location = new Point(487, 246);
            btnBeli.Margin = new Padding(2);
            btnBeli.Name = "btnBeli";
            btnBeli.Size = new Size(138, 48);
            btnBeli.TabIndex = 5;
            btnBeli.Text = "Checkout";
            btnBeli.UseVisualStyleBackColor = false;
            btnBeli.Click += btnBeli_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 33, 36);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 40);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 33, 36);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 410);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 40);
            panel2.TabIndex = 7;
            // 
            // DetailProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnBeli);
            Controls.Add(btnKeranjang);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "DetailProduk";
            Text = "DetailProduk";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnKeranjang;
        private Button btnBeli;
        private Panel panel1;
        private Panel panel2;
    }
}