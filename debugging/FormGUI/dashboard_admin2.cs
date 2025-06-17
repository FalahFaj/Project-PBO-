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
using debugging.PenghubungDB;
using debugging.AksesLayer;
using debugging.FormGUI;
using debugging.Assets;

namespace debugging
{
    public partial class dashboard_admin2 : Form
    {
        private FlowLayoutPanel? flowLayoutPanel3;
        private Dictionary<int, Image> adminImageCache = new();
        private Riwayat_Transaksi? history;
        private formhomeadmin? formHomeAdmin;
        private Kelola? kelolaForm;
        private Status? status;
        private Chat_admin? chatadmin;
        private Kelola_Product? kelolaProduct;
        private readonly ServiceAkun serviceAkun;
        private readonly ServiceProduk serviceProduk;
        private readonly IAksesProduk aksesProduk;
        private readonly IServiceRiwayat serviceRiwayat;
        private readonly UserLogin akun;

        public dashboard_admin2(
              ServiceAkun serviceAkun,
              ServiceProduk serviceProduk,
              IAksesProduk aksesProduk,
              IServiceRiwayat serviceRiwayat,
              UserLogin akun)
        {
            InitializeComponent();
            this.serviceAkun = serviceAkun;
            this.serviceProduk = serviceProduk;
            this.aksesProduk = aksesProduk;
            this.serviceRiwayat = serviceRiwayat;
            this.akun = akun;
            this.IsMdiContainer = true;
        }


        bool sidebarExpand = true;
        bool menuExpand = false;
        private IList<string> bulanLabels;
        private ObservableCollection<double> _data = new ObservableCollection<double>();

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowChildForm<T>(ref T formInstance, Func<T> formFactory) where T : Form
        {
            if (formInstance == null || formInstance.IsDisposed)
            {
                formInstance = formFactory();
                formInstance.MdiParent = this;
                formInstance.Dock = DockStyle.Fill;
                formInstance.Show();
            }
            else
            {
                formInstance.Activate();
            }
        }
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
                if (flowLayoutPanel1.Width <= 50)
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
            ShowChildForm(ref chatadmin, () => new Chat_admin());
        }
        private void Chatadmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            chatadmin = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (history == null || history.IsDisposed)
            {
                history = new Riwayat_Transaksi(this.serviceRiwayat);
                history.FormClosed += (s, args) => history = null; 
                history.MdiParent = this;
                history.Dock = DockStyle.Fill;
                history.Show();
            }
            else
            {
                history.Activate();
            }
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (status == null || status.IsDisposed)
            {
                status = new Status(this.serviceRiwayat); 
                status.FormClosed += (s, args) => status = null;
                status.MdiParent = this;
                status.Dock = DockStyle.Fill;
                status.Show();
            }
            else
            {
                status.Activate();
            }
        }
        private void History_FormClosed(object sender, FormClosedEventArgs e)
        {
            history = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(this.serviceAkun);
            login.ShowDialog();
            this.Hide();
        }

        private void dashboard_admin2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowChildForm(ref formHomeAdmin, () => new formhomeadmin(serviceProduk));
        }
        private void FormHomeAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            formHomeAdmin = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowChildForm(ref kelolaForm, () => new Kelola(serviceProduk, aksesProduk as AksesProduk));
        }
    }
}