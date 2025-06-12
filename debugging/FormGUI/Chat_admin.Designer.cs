namespace debugging
{
    partial class Chat_admin
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
            TxtPesan = new TextBox();
            BtnSend = new FontAwesome.Sharp.IconButton();
            LblNamaUser = new Label();
            flpKolomChat = new FlowLayoutPanel();
            flpKolomUser = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // TxtPesan
            // 
            TxtPesan.Location = new Point(331, 499);
            TxtPesan.Margin = new Padding(4);
            TxtPesan.Name = "TxtPesan";
            TxtPesan.Size = new Size(573, 31);
            TxtPesan.TabIndex = 2;
            TxtPesan.TextChanged += TxtPesan_TextChanged;
            // 
            // BtnSend
            // 
            BtnSend.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            BtnSend.IconColor = Color.Green;
            BtnSend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSend.IconSize = 40;
            BtnSend.Location = new Point(911, 490);
            BtnSend.Margin = new Padding(4);
            BtnSend.Name = "BtnSend";
            BtnSend.Size = new Size(52, 50);
            BtnSend.TabIndex = 4;
            BtnSend.UseVisualStyleBackColor = true;
            BtnSend.Click += BtnSend_Click;
            // 
            // LblNamaUser
            // 
            LblNamaUser.AutoSize = true;
            LblNamaUser.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNamaUser.Location = new Point(385, 9);
            LblNamaUser.Margin = new Padding(4, 0, 4, 0);
            LblNamaUser.Name = "LblNamaUser";
            LblNamaUser.Size = new Size(19, 29);
            LblNamaUser.TabIndex = 5;
            LblNamaUser.Text = " ";
            // 
            // flpKolomChat
            // 
            flpKolomChat.AutoScroll = true;
            flpKolomChat.BackColor = SystemColors.ActiveCaption;
            flpKolomChat.FlowDirection = FlowDirection.TopDown;
            flpKolomChat.Location = new Point(317, 49);
            flpKolomChat.Margin = new Padding(4);
            flpKolomChat.Name = "flpKolomChat";
            flpKolomChat.Size = new Size(651, 438);
            flpKolomChat.TabIndex = 6;
            flpKolomChat.WrapContents = false;
            flpKolomChat.Paint += flpKolomChat_Paint;
            // 
            // flpKolomUser
            // 
            flpKolomUser.BackColor = Color.FromArgb(255, 192, 128);
            flpKolomUser.Location = new Point(15, 49);
            flpKolomUser.Margin = new Padding(4);
            flpKolomUser.Name = "flpKolomUser";
            flpKolomUser.Size = new Size(294, 484);
            flpKolomUser.TabIndex = 7;
            flpKolomUser.Paint += flpKolomUser_Paint;
            // 
            // Chat_admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(flpKolomUser);
            Controls.Add(LblNamaUser);
            Controls.Add(BtnSend);
            Controls.Add(TxtPesan);
            Controls.Add(flpKolomChat);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Chat_admin";
            Text = "Chat_admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtPesan;
        private FontAwesome.Sharp.IconButton BtnSend;
        private Label LblNamaUser;
        private FlowLayoutPanel flpKolomChat;
        private FlowLayoutPanel flpKolomUser;
    }
}