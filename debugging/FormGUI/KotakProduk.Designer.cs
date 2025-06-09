namespace debugging.FormGUI
{
    partial class KotakProduk
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

        #region Component Designer generated code  

        /// <summary>   
        /// Required method for Designer support - do not modify   
        /// the contents of this method with the code editor.  
        /// </summary>  
        private void InitializeComponent()
        {
            pictureBoxProduk = new PictureBox();
            labelNamaProduk = new Label();
            labelHargaProduk = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduk).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProduk
            // 
            pictureBoxProduk.Dock = DockStyle.Fill;
            pictureBoxProduk.Location = new Point(0, 0);
            pictureBoxProduk.Name = "pictureBoxProduk";
            pictureBoxProduk.Size = new Size(100, 100);
            pictureBoxProduk.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProduk.TabIndex = 0;
            pictureBoxProduk.TabStop = false;
            // 
            // labelNamaProduk
            // 
            labelNamaProduk.Dock = DockStyle.Top;
            labelNamaProduk.Font = new Font("Arial", 12F, FontStyle.Bold);
            labelNamaProduk.Location = new Point(0, 0);
            labelNamaProduk.Name = "labelNamaProduk";
            labelNamaProduk.Padding = new Padding(5);
            labelNamaProduk.Size = new Size(100, 23);
            labelNamaProduk.TabIndex = 1;
            // 
            // labelHargaProduk
            // 
            labelHargaProduk.Dock = DockStyle.Top;
            labelHargaProduk.Font = new Font("Arial", 10F);
            labelHargaProduk.Location = new Point(0, 0);
            labelHargaProduk.Name = "labelHargaProduk";
            labelHargaProduk.Padding = new Padding(5);
            labelHargaProduk.Size = new Size(100, 23);
            labelHargaProduk.TabIndex = 2;
            // 
            // KotakProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pictureBoxProduk);
            Controls.Add(labelNamaProduk);
            Controls.Add(labelHargaProduk);
            Name = "KotakProduk";
            Size = new Size(150, 200);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduk).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxProduk;
        private Label labelNamaProduk;
        private Label labelHargaProduk;
    }
}
