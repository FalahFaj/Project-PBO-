using System.ComponentModel.DataAnnotations.Schema;

namespace debugging
{
    [NotMapped]
    partial class DashboardUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardUser));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pnCategories = new Panel();
            pictureBox7 = new PictureBox();
            button6 = new Button();
            subpnMahar = new Panel();
            pictureBox6 = new PictureBox();
            button5 = new Button();
            subpnSeserahan = new Panel();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            subpnSuvernir = new Panel();
            pictureBox8 = new PictureBox();
            button7 = new Button();
            pnbarang = new Panel();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            pnAboutus = new Panel();
            pictureBox4 = new PictureBox();
            button3 = new Button();
            pnlogout = new Panel();
            pictureBox5 = new PictureBox();
            button4 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            pnCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            subpnMahar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            subpnSeserahan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            subpnSuvernir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            pnbarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnAboutus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 33, 36);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 2);
            label1.Name = "label1";
            label1.Size = new Size(216, 20);
            label1.TabIndex = 1;
            label1.Text = "Cantiknya Mahar   Products";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(23, 24, 29);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(pnbarang);
            flowLayoutPanel1.Controls.Add(pnAboutus);
            flowLayoutPanel1.Controls.Add(pnlogout);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 50);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(247, 550);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(32, 33, 36);
            flowLayoutPanel2.Controls.Add(pnCategories);
            flowLayoutPanel2.Controls.Add(subpnMahar);
            flowLayoutPanel2.Controls.Add(subpnSeserahan);
            flowLayoutPanel2.Controls.Add(subpnSuvernir);
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(191, 59);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // pnCategories
            // 
            pnCategories.Controls.Add(pictureBox7);
            pnCategories.Controls.Add(button6);
            pnCategories.Location = new Point(0, 0);
            pnCategories.Margin = new Padding(0);
            pnCategories.Name = "pnCategories";
            pnCategories.Size = new Size(192, 59);
            pnCategories.TabIndex = 6;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(23, 24, 29);
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(4, 9);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(53, 30);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 2;
            pictureBox7.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(23, 24, 29);
            button6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-4, -33);
            button6.Name = "button6";
            button6.Size = new Size(229, 120);
            button6.TabIndex = 2;
            button6.Text = "             Categories";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // subpnMahar
            // 
            subpnMahar.Controls.Add(pictureBox6);
            subpnMahar.Controls.Add(button5);
            subpnMahar.Location = new Point(3, 62);
            subpnMahar.Name = "subpnMahar";
            subpnMahar.Size = new Size(192, 59);
            subpnMahar.TabIndex = 4;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1, 9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(53, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(32, 33, 36);
            button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-4, -33);
            button5.Name = "button5";
            button5.Size = new Size(229, 120);
            button5.TabIndex = 2;
            button5.Text = "             Mahar";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // subpnSeserahan
            // 
            subpnSeserahan.Controls.Add(pictureBox2);
            subpnSeserahan.Controls.Add(button1);
            subpnSeserahan.Location = new Point(3, 127);
            subpnSeserahan.Name = "subpnSeserahan";
            subpnSeserahan.Size = new Size(192, 59);
            subpnSeserahan.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 33, 36);
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-4, -33);
            button1.Name = "button1";
            button1.Size = new Size(229, 120);
            button1.TabIndex = 2;
            button1.Text = "             Seserahan";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // subpnSuvernir
            // 
            subpnSuvernir.Controls.Add(pictureBox8);
            subpnSuvernir.Controls.Add(button7);
            subpnSuvernir.Location = new Point(3, 192);
            subpnSuvernir.Name = "subpnSuvernir";
            subpnSuvernir.Size = new Size(192, 59);
            subpnSuvernir.TabIndex = 7;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(1, 9);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(53, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 2;
            pictureBox8.TabStop = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(32, 33, 36);
            button7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-4, -33);
            button7.Name = "button7";
            button7.Size = new Size(229, 120);
            button7.TabIndex = 2;
            button7.Text = "             Souvernir";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // pnbarang
            // 
            pnbarang.Controls.Add(pictureBox3);
            pnbarang.Controls.Add(button2);
            pnbarang.Location = new Point(3, 62);
            pnbarang.Name = "pnbarang";
            pnbarang.Size = new Size(191, 59);
            pnbarang.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(23, 24, 29);
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-4, -31);
            button2.Name = "button2";
            button2.Size = new Size(229, 120);
            button2.TabIndex = 2;
            button2.Text = "             Keranjang";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // pnAboutus
            // 
            pnAboutus.Controls.Add(pictureBox4);
            pnAboutus.Controls.Add(button3);
            pnAboutus.Location = new Point(3, 127);
            pnAboutus.Name = "pnAboutus";
            pnAboutus.Size = new Size(191, 59);
            pnAboutus.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(23, 24, 29);
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-5, -31);
            button3.Name = "button3";
            button3.Size = new Size(229, 120);
            button3.TabIndex = 2;
            button3.Text = "             About Us";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pnlogout
            // 
            pnlogout.Controls.Add(pictureBox5);
            pnlogout.Controls.Add(button4);
            pnlogout.Location = new Point(3, 192);
            pnlogout.Name = "pnlogout";
            pnlogout.Size = new Size(191, 59);
            pnlogout.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1, 9);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(53, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(23, 24, 29);
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-5, -31);
            button4.Name = "button4";
            button4.Size = new Size(229, 120);
            button4.TabIndex = 2;
            button4.Text = "             Logout";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoScroll = true;
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(247, 50);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(853, 550);
            flowLayoutPanel3.TabIndex = 7;
            // 
            // DashboardUser
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1100, 600);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "DashboardUser";
            Load += DashboardUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            pnCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            subpnMahar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            subpnSeserahan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            subpnSuvernir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            pnbarang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnAboutus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlogout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnbarang;
        private PictureBox pictureBox3;
        private Button button2;
        private Panel pnAboutus;
        private PictureBox pictureBox4;
        private Button button3;
        private Panel pnlogout;
        private PictureBox pictureBox5;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Timer timer1;
        private Panel subpnMahar;
        private PictureBox pictureBox6;
        private Button button5;
        private Panel subpnSeserahan;
        private PictureBox pictureBox2;
        private Button button1;
        private Panel pnCategories;
        private PictureBox pictureBox7;
        private Button button6;
        private Panel subpnSuvernir;
        private PictureBox pictureBox8;
        private Button button7;
        private System.Windows.Forms.Timer timer2;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}