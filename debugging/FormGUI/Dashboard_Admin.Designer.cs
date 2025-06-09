namespace Project_PBO_Kel_5
{
    partial class Dashboard_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Admin));
            panel1 = new Panel();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox10 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            btnKelolaProduk = new PictureBox();
            btnChat = new PictureBox();
            btnHome = new PictureBox();
            panel4 = new Panel();
            pictureBox8 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            pictureBox9 = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            cartesianChart2 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox7 = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKelolaProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnChat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 54);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(977, 9);
            button3.Name = "button3";
            button3.Size = new Size(24, 30);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(1007, 10);
            button4.Name = "button4";
            button4.Size = new Size(33, 29);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(911, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(43, 12);
            button1.Name = "button1";
            button1.Size = new Size(35, 36);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.Control;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1046, 10);
            button2.Name = "button2";
            button2.Size = new Size(33, 29);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(123, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 3;
            label1.Text = "Dashboard Admin";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 62, 80);
            panel2.Controls.Add(pictureBox10);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(btnKelolaProduk);
            panel2.Controls.Add(btnChat);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(123, 573);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(29, 388);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(49, 46);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 12;
            pictureBox10.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(29, 295);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(49, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(29, 485);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(49, 39);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // btnKelolaProduk
            // 
            btnKelolaProduk.Image = (Image)resources.GetObject("btnKelolaProduk.Image");
            btnKelolaProduk.Location = new Point(29, 199);
            btnKelolaProduk.Name = "btnKelolaProduk";
            btnKelolaProduk.Size = new Size(49, 39);
            btnKelolaProduk.SizeMode = PictureBoxSizeMode.Zoom;
            btnKelolaProduk.TabIndex = 8;
            btnKelolaProduk.TabStop = false;
            // 
            // btnChat
            // 
            btnChat.Image = (Image)resources.GetObject("btnChat.Image");
            btnChat.Location = new Point(29, 107);
            btnChat.Name = "btnChat";
            btnChat.Size = new Size(49, 39);
            btnChat.SizeMode = PictureBoxSizeMode.Zoom;
            btnChat.TabIndex = 7;
            btnChat.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(29, 19);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(49, 39);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 6;
            btnHome.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(26, 188, 156);
            panel4.Controls.Add(pictureBox8);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(492, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(221, 124);
            panel4.TabIndex = 3;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.Location = new Point(152, 35);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(66, 61);
            pictureBox8.TabIndex = 9;
            pictureBox8.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(14, 36);
            label6.Name = "label6";
            label6.Size = new Size(60, 46);
            label6.TabIndex = 8;
            label6.Text = "50";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(14, 13);
            label5.Name = "label5";
            label5.Size = new Size(47, 23);
            label5.TabIndex = 7;
            label5.Text = "Rent";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(231, 76, 60);
            panel5.Controls.Add(pictureBox9);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(819, 60);
            panel5.Name = "panel5";
            panel5.Size = new Size(221, 124);
            panel5.TabIndex = 4;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.Location = new Point(152, 35);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(66, 61);
            pictureBox9.TabIndex = 10;
            pictureBox9.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(0, 47);
            label8.Name = "label8";
            label8.Size = new Size(150, 30);
            label8.TabIndex = 9;
            label8.Text = "RP 52.000.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(12, 13);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 8;
            label7.Text = "Income";
            // 
            // cartesianChart1
            // 
            cartesianChart1.BackColor = Color.WhiteSmoke;
            cartesianChart1.Location = new Point(625, 326);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(433, 219);
            cartesianChart1.TabIndex = 6;
            cartesianChart1.Load += cartesianChart1_Load;
            // 
            // cartesianChart2
            // 
            cartesianChart2.BackColor = Color.WhiteSmoke;
            cartesianChart2.Location = new Point(156, 326);
            cartesianChart2.MatchAxesScreenDataRatio = false;
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(448, 219);
            cartesianChart2.TabIndex = 7;
            cartesianChart2.Load += cartesianChart2_Load;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(52, 152, 219);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(156, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 124);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(0, 35);
            label3.Name = "label3";
            label3.Size = new Size(100, 46);
            label3.TabIndex = 7;
            label3.Text = "1357";
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.Location = new Point(152, 35);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(66, 61);
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(3, 91);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 8;
            label4.Text = "15 new orders";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(13, 13);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 6;
            label2.Text = "Orders";
            // 
            // Dashboard_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1082, 627);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(cartesianChart2);
            Controls.Add(cartesianChart1);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard_Admin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKelolaProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnChat).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button4;
        private Button button2;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox8;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox9;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox10;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox7;
        private Label label4;
        private Label label2;
        private PictureBox btnKelolaProduk;
        private PictureBox btnChat;
        private PictureBox btnHome;
    }
}