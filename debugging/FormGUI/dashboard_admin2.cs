using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using debugging.Model;
using debugging.Service;

namespace debugging
{
    public partial class dashboard_admin2 : Form
    {
        private readonly ServiceAkun serviceAkun;
        private readonly UserLogin akun;
        private readonly ServiceProduk serviceProduk;
        //Chat_admin chatadmin;
        //Status status;
        //SubMahar subMahar;
        //SubSeserahan subSeserahan;
        //SubSuvernir subSuvernir;
        //Riwayat_Transaksi history;
        //formhomeadmin Formhomeadmin;

        public dashboard_admin2(ServiceAkun serviceAkun, UserLogin akun)
        {
            InitializeComponent();
            this.serviceAkun = serviceAkun;
            this.akun = akun;
            this.IsMdiContainer = true;
        }
        bool sidebarExpand = true;
        bool menuExpand = false;
        private IList<string> bulanLabels;
        private ObservableCollection<double> _data = new ObservableCollection<double>();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == false)
            {
                flowLayoutPanel1.Width += 5;
                if (flowLayoutPanel1.Width >= 220)
                {
                    timer1.Stop();
                    sidebarExpand = true;
                }
            }
            else
            {
                flowLayoutPanel1.Width -= 5;
                if (flowLayoutPanel1.Width <= 94)
                {
                    timer1.Stop();
                    sidebarExpand = false;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartesianChart1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 1; i <= 12; i++)
            {
                _data.Add(rand.Next(0, 100));
            }


        }

        private void cartesianChart2_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            var dataBeli = new ObservableCollection<double>();
            var dataSewa = new ObservableCollection<double>();

            for (int i = 1; i <= 12; i++)
            {
                dataBeli.Add(rand.Next(20, 100));
                dataSewa.Add(rand.Next(10, 80));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fitur ini belum tersedia.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //if (chatadmin == null)
            //{
            //    chatadmin = new Chat_admin();
            //    chatadmin.FormClosed += Chatadmin_FormClosed;
            //    chatadmin.MdiParent = this;
            //    chatadmin.Dock = DockStyle.Fill;
            //    chatadmin.Show();
            //}
            //else
            //{
            //    chatadmin.Activate();
            //}
        }
        //private void Chatadmin_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    chatadmin = null;
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fitur ini belum tersedia.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //if (status == null)
            //{
            //    status = new Status(serviceAkun, akun);
            //    status.FormClosed += Status_FormClosed;
            //    status.MdiParent = this;
            //    status.Dock = DockStyle.Fill;
            //    status.Show();
            //}
            //else
            //{
            //    status.Activate();
            //}
        }
        //private void Status_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    status = null;
        //}

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                flowLayoutPanel2.Height += 10;
                if (flowLayoutPanel2.Height >= 254)
                {
                    timer2.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flowLayoutPanel2.Height -= 10;
                if (flowLayoutPanel2.Height <= 59)
                {
                    timer2.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //if (subMahar == null)
            //{
            //    subMahar = new SubMahar();
            //    subMahar.FormClosed += SubMahar_FormClosed;
            //    subMahar.MdiParent = this;
            //    subMahar.Dock = DockStyle.Fill;
            //    subMahar.Show();
            //}
            //else
            //{
            //    subMahar.Activate();
            //}
        }
        //private void SubMahar_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    subMahar = null;
        //}

        private void button8_Click(object sender, EventArgs e)
        {
            //if (subSeserahan == null)
            //{
            //    subSeserahan = new SubSeserahan();
            //    subSeserahan.FormClosed += SubSeserahan_FormClosed;
            //    subSeserahan.MdiParent = this;
            //    subSeserahan.Dock = DockStyle.Fill;
            //    subSeserahan.Show();
            //}
            //else
            //{
            //    subSeserahan.Activate();
            //}
        }
        //private void SubSeserahan_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    subSeserahan = null;
        //}

        private void button9_Click(object sender, EventArgs e)
        {
            //if (subSuvernir == null)
            //{
            //    subSuvernir = new SubSuvernir();
            //    subSuvernir.FormClosed += SubSuvernir_FormClosed;
            //    subSuvernir.MdiParent = this;
            //    subSuvernir.Dock = DockStyle.Fill;
            //    subSuvernir.Show();
            //}
            //else
            //{
            //    subSuvernir.Activate();
            //}
        }
        //private void SubSuvernir_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    subSuvernir = null;
        //}

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fitur ini belum tersedia.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //if (history == null)
            //{
            //    history = new Riwayat_Transaksi();
            //    history.FormClosed += History_FormClosed;
            //    history.MdiParent = this;
            //    history.Dock = DockStyle.Fill;
            //    history.Show();
            //}
            //else
            //{
            //    history.Activate();
            //}
        }
        //private void History_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    history = null;
        //}

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Hide();
        }

        private void dashboard_admin2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fitur ini belum tersedia.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //if (Formhomeadmin == null)
            //{
            //    Formhomeadmin = new formhomeadmin();
            //    Formhomeadmin.FormClosed += Formhomeadmin_FormClosed;
            //    Formhomeadmin.MdiParent = this;
            //    Formhomeadmin.Dock = DockStyle.Fill;
            //    Formhomeadmin.Show();
            //}
            //else
            //{
            //    Formhomeadmin.Activate();
            //}
        }
        //private void Formhomeadmin_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    Formhomeadmin = null;
        //}
    }
}
