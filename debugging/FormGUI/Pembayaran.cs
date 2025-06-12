using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel.DataAnnotations.Schema;

namespace debugging
{
    public partial class Pembayaran : Form
    {
        private bool sidebarexpand;
        private Panel sidebar = new Panel();
        private System.Windows.Forms.Timer sidebarTimer;
        public Pembayaran()
        {
            InitializeComponent();
            SidebarContainer.Visible = true;
        }

        private void Pembayaran_Load(object sender, EventArgs e)
        {
            sidebar = new Panel();
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Size = new Size(50, this.Height);
            sidebar.MinimumSize = new Size(50, this.Height);
            sidebar.MaximumSize = new Size(200, this.Height);
            this.Controls.Add(sidebar);

            string[] menuItems = { "Menu", "Home", "Settings", "Back" };
            int[] labelYPositions = { 28, 117, 174, 235 };
            int[] labelXpositions = { 80, 80, 80, 80 };

            for (int i = 0; i < menuItems.Length; i++)
            {
                Label sidebarLabel = new Label();
                sidebarLabel.Font = new Font("Poppins", 9, FontStyle.Bold);
                sidebarLabel.Text = menuItems[i];
                sidebarLabel.ForeColor = Color.White;
                sidebarLabel.BackColor = Color.Transparent;
                sidebarLabel.AutoSize = true;
                sidebarLabel.Location = new Point(labelXpositions[i], labelYPositions[i]);

                sidebar.Controls.Add(sidebarLabel);
            }
            sidebarTimer = new System.Windows.Forms.Timer();
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += SidebarTimer_Tick;
            sidebarexpand = false;
            sidebarTimer = new System.Windows.Forms.Timer();
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += SidebarTimer_Tick;

            sidebarexpand = false;
        }


        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarexpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarexpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarexpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            if (sidebarTimer != null)
            {
                sidebarTimer.Start();
            }
            else
            {
                MessageBox.Show("Sidebar belum diinisialisasi");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardUser form = new DashboardUser();
            form.ShowDialog();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public static implicit operator Pembayaran(Panel v)
        {
            throw new NotImplementedException();
        }
    }
}
