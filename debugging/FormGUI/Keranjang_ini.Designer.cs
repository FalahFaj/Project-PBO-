namespace debugging.FormGUI
{
    partial class Keranjang_ini
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnBeli = new Button();
            label1 = new Label();
            flpProduk_keranjang = new FlowLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 24, 29);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 56);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnBeli
            // 
            btnBeli.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBeli.AutoSize = true;
            btnBeli.Location = new Point(692, 13);
            btnBeli.Margin = new Padding(2);
            btnBeli.Name = "btnBeli";
            btnBeli.Size = new Size(143, 49);
            btnBeli.TabIndex = 3;
            btnBeli.Text = "Beli";
            btnBeli.UseVisualStyleBackColor = true;
            btnBeli.Click += btnBeli_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(0, 58);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(228, 31);
            label1.TabIndex = 5;
            label1.Text = "Keranjang Kamu";
            // 
            // flpProduk_keranjang
            // 
            flpProduk_keranjang.AutoScroll = true;
            flpProduk_keranjang.FlowDirection = FlowDirection.TopDown;
            flpProduk_keranjang.Location = new Point(0, 100);
            flpProduk_keranjang.Name = "flpProduk_keranjang";
            flpProduk_keranjang.Size = new Size(846, 331);
            flpProduk_keranjang.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(846, 51);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnBeli);
            panel3.Location = new Point(0, 437);
            panel3.Name = "panel3";
            panel3.Size = new Size(846, 64);
            panel3.TabIndex = 0;
            // 
            // Keranjang_ini
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(846, 500);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(flpProduk_keranjang);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Keranjang_ini";
            Text = "Keranjang_ini";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnBeli;
        private Label label1;
        private FlowLayoutPanel flpProduk_keranjang;
        private Panel panel2;
        private Panel panel3;
    }
}