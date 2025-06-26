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
            btnBeli = new Button();
            label1 = new Label();
            flpProduk_keranjang = new FlowLayoutPanel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // btnBeli
            // 
            btnBeli.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBeli.AutoSize = true;
            btnBeli.Location = new Point(1182, 694);
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
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(245, 15);
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
            flpProduk_keranjang.Location = new Point(0, 65);
            flpProduk_keranjang.Name = "flpProduk_keranjang";
            flpProduk_keranjang.Size = new Size(1337, 611);
            flpProduk_keranjang.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Location = new Point(0, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(1337, 51);
            panel2.TabIndex = 7;
            // 
            // Keranjang_ini
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1336, 754);
            Controls.Add(btnBeli);
            Controls.Add(panel2);
            Controls.Add(flpProduk_keranjang);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Keranjang_ini";
            Text = "Keranjang_ini";
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