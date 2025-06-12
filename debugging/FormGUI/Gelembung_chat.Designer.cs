namespace debugging
{
    partial class Gelembung_chat
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
            lblPesan = new Label();
            lblWaktu = new Label();
            panelPesan = new Panel();
            panelPesan.SuspendLayout();
            SuspendLayout();
            // 
            // lblPesan
            // 
            lblPesan.AutoSize = true;
            lblPesan.Font = new Font("Segoe UI", 10F);
            lblPesan.Location = new Point(10, 10);
            lblPesan.MaximumSize = new Size(250, 0);
            lblPesan.Name = "lblPesan";
            lblPesan.Size = new Size(54, 23);
            lblPesan.TabIndex = 0;
            lblPesan.Text = "Pesan";
            lblPesan.Click += lblPesan_Click_1;
            // 
            // lblWaktu
            // 
            lblWaktu.AutoSize = true;
            lblWaktu.Font = new Font("Segoe UI", 7F, FontStyle.Italic);
            lblWaktu.ForeColor = Color.Gray;
            lblWaktu.Location = new Point(0, 0);
            lblWaktu.Name = "lblWaktu";
            lblWaktu.Size = new Size(34, 15);
            lblWaktu.TabIndex = 1;
            lblWaktu.Text = "12:34";
            // 
            // panelPesan
            // 
            panelPesan.AutoSize = true;
            panelPesan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelPesan.BackColor = Color.WhiteSmoke;
            panelPesan.Controls.Add(lblPesan);
            panelPesan.Controls.Add(lblWaktu);
            panelPesan.Location = new Point(0, 0);
            panelPesan.Margin = new Padding(5);
            panelPesan.Name = "panelPesan";
            panelPesan.Padding = new Padding(10);
            panelPesan.Size = new Size(77, 43);
            panelPesan.TabIndex = 0;
            // 
            // Gelembung_chat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(panelPesan);
            Margin = new Padding(5);
            Name = "Gelembung_chat";
            Size = new Size(82, 48);
            panelPesan.ResumeLayout(false);
            panelPesan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPesan;
        private System.Windows.Forms.Label lblWaktu;
        private Panel panelPesan;
    }
}
