using System.ComponentModel.DataAnnotations.Schema;

namespace debugging
{
    [NotMapped]
    partial class AboutUs
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
            label1 = new Label();
            label2 = new Label();
            fufufafa = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            lblNama = new Label();
            lblNo_HP = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            lblAlamat = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 51);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 93);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "No HP";
            // 
            // fufufafa
            // 
            fufufafa.AutoSize = true;
            fufufafa.Location = new Point(68, 140);
            fufufafa.Margin = new Padding(2, 0, 2, 0);
            fufufafa.Name = "fufufafa";
            fufufafa.Size = new Size(75, 20);
            fufufafa.TabIndex = 2;
            fufufafa.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 187);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 237);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 286);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 5;
            label5.Text = "Alamat";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(243, 51);
            lblNama.Margin = new Padding(2, 0, 2, 0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(0, 20);
            lblNama.TabIndex = 6;
            // 
            // lblNo_HP
            // 
            lblNo_HP.AutoSize = true;
            lblNo_HP.Location = new Point(243, 93);
            lblNo_HP.Margin = new Padding(2, 0, 2, 0);
            lblNo_HP.Name = "lblNo_HP";
            lblNo_HP.Size = new Size(0, 20);
            lblNo_HP.TabIndex = 7;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(243, 140);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 20);
            lblUsername.TabIndex = 8;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(243, 187);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(0, 20);
            lblPassword.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(243, 237);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(0, 20);
            lblEmail.TabIndex = 10;
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(243, 286);
            lblAlamat.Margin = new Padding(2, 0, 2, 0);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(0, 20);
            lblAlamat.TabIndex = 11;
            // 
            // AboutUs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(lblAlamat);
            Controls.Add(lblEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblNo_HP);
            Controls.Add(lblNama);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(fufufafa);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AboutUs";
            Text = "AboutUs";
            Load += AboutUs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label fufufafa;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label lblNama;
        private Label lblNo_HP;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblAlamat;
    }
}