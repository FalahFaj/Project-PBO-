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
using System.Globalization;
using debugging.Service;

namespace debugging
{
    public partial class formhomeadmin : Form
    {

        private readonly ServiceProduk serviceProduk;
        public formhomeadmin(ServiceProduk serviceProduk)
        {
            InitializeComponent();
            this.serviceProduk = serviceProduk;
        }


        void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LoadDashboardData()
        {
            try
            {
                int totaldisewa = serviceProduk.GetTotalBarangDisewa();
                int totaldijual = serviceProduk.GetTotalBarangDijual();
                decimal totalpemasukan = serviceProduk.GetTotalPemasukan();
                int Barangblmdikembalikan = serviceProduk.Getbarangbelumdikembalikan();
                jmlhdisewa.Text = totaldisewa.ToString();
                jmlhdijual.Text = totaldijual.ToString();
                var culture = new CultureInfo("id-ID");
                jmlhpemasukan.Text = totalpemasukan.ToString("C0", culture);
                barangbelumdikembalikan.Text = Barangblmdikembalikan.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data dashboard. Pastikan koneksi database tidak eror" + ex.Message,
                    "Kesalahan Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void jmlhpemasukan_Click(object sender, EventArgs e)
        {

        }

        private void formhomeadmin_Load_1(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}