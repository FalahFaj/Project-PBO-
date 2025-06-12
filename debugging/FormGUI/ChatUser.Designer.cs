namespace debugging
{
    partial class ChatUser
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

        private void InitializeComponent()
        {
            lblNamaUser = new Label();
            lblPesanTerakhir = new Label();
            lblWaktu = new Label();
            SuspendLayout();
            // 
            // lblNamaUser
            // 
            lblNamaUser.AutoSize = true;
            lblNamaUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNamaUser.Location = new Point(10, 5);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(116, 28);
            lblNamaUser.TabIndex = 0;
            lblNamaUser.Text = "Nama User";
            // 
            // lblPesanTerakhir
            // 
            lblPesanTerakhir.AutoSize = true;
            lblPesanTerakhir.Font = new Font("Segoe UI", 9F);
            lblPesanTerakhir.ForeColor = SystemColors.ControlDarkDark;
            lblPesanTerakhir.Location = new Point(10, 27);
            lblPesanTerakhir.Name = "lblPesanTerakhir";
            lblPesanTerakhir.Size = new Size(133, 25);
            lblPesanTerakhir.TabIndex = 1;
            lblPesanTerakhir.Text = "Pesan terakhir...";
            // 
            // lblWaktu
            // 
            lblWaktu.Anchor = AnchorStyles.Right;
            lblWaktu.AutoSize = true;
            lblWaktu.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblWaktu.ForeColor = SystemColors.GrayText;
            lblWaktu.Location = new Point(182, 12);
            lblWaktu.Name = "lblWaktu";
            lblWaktu.Size = new Size(49, 21);
            lblWaktu.TabIndex = 2;
            lblWaktu.Text = "12:45";
            // 
            // ChatUser
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblWaktu);
            Controls.Add(lblPesanTerakhir);
            Controls.Add(lblNamaUser);
            Name = "ChatUser";
            Size = new Size(232, 64);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNamaUser;
        private Label lblPesanTerakhir;
        private Label lblWaktu;
    }
}
