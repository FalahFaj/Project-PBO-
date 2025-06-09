using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using debugging.AksesLayer;
using debugging.FormGUI;
using debugging.Model;
using debugging.PenghubungDB;
using debugging.Service;
using debugging.Assets;

namespace Project_PBO_Kel_5
{
    public partial class DashboardUser : Form
    {
        AboutUs aboutUs;
        Keranjang keranjang;
        SubMahar subMahar;
        SubSeserahan subSeserahan;
        SubSuvernir subSuvernir;
        private readonly ServiceProduk serviceProduk;
        private readonly ServiceAkun serviceAkun;
        private readonly UserLogin akun;
        public DashboardUser(ServiceAkun serviceAkun, UserLogin akun)
        {
            InitializeComponent();
            this.serviceAkun = serviceAkun;
            this.akun = akun;

            KoneksiDB koneksiDB = new KoneksiDB();
            IAksesProduk aksesproduk = new AksesProduk(koneksiDB);
            this.serviceProduk = new ServiceProduk(aksesproduk);

            LoadProducts(serviceProduk);
        }
        private void LoadProducts(ServiceProduk serviceProduk)
        {
            var produk = serviceProduk.GetAllProduk();  
            foreach (var item in produk)
            {
                var kartu = new KotakProduk
                {
                    NamaProduk = item.nama,
                    HargaProduk = item.harga,
                    FotoProduk = FotoProduk(item.foto),
                    Margin = new Padding(10, 10, 10, 10)
                };
                kartu.Padding = new Padding(5);
                kartu.Width = 170;
                kartu.Height = 300;
                flowLayoutPanel3.Controls.Add(kartu);
            }
        }

        private static Image FotoProduk(byte[] byteFoto)
        {
            try
            {
                if (byteFoto != null && byteFoto.Length > 0)
                {
                    using (var ms = new MemoryStream(byteFoto))
                    {
                        return Image.FromStream(ms);
                    }
                }

                var fotoDefault = FotoDefault.GetFotoDefault();
                if (fotoDefault != null && fotoDefault.Length > 0)
                {
                    using (var ms = new MemoryStream(fotoDefault))
                    {
                        return Image.FromStream(ms);
                    }
                }
            }
            catch
            {
                // Log or handle the exception if necessary  
            }

            return null;
        }

        bool menuExpand = false;
        bool sidebarExpand = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                flowLayoutPanel2.Height += 10;
                if (flowLayoutPanel2.Height >= 254)
                {
                    timer1.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flowLayoutPanel2.Height -= 10;
                if (flowLayoutPanel2.Height <= 59)
                {
                    timer1.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == false)
            {
                flowLayoutPanel1.Width += 5;
                if (flowLayoutPanel1.Width >= 247)
                {
                    timer2.Stop();
                    sidebarExpand = true;

                    pnCategories.Width = flowLayoutPanel1.Width;
                    pnbarang.Width = flowLayoutPanel1.Width;
                    pnAboutus.Width = flowLayoutPanel1.Width;
                    pnlogout.Width = flowLayoutPanel1.Width;
                    flowLayoutPanel2.Width = flowLayoutPanel1.Width;
                }
            }
            else
            {
                flowLayoutPanel1.Width -= 5;
                if (flowLayoutPanel1.Width <= 62)
                {
                    timer2.Stop();
                    sidebarExpand = false;

                    pnCategories.Width = flowLayoutPanel1.Width;
                    pnbarang.Width = flowLayoutPanel1.Width;
                    pnAboutus.Width = flowLayoutPanel1.Width;
                    pnlogout.Width = flowLayoutPanel1.Width;
                    flowLayoutPanel2.Width = flowLayoutPanel1.Width;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (keranjang == null)
            {
                keranjang = new Keranjang();
                keranjang.FormClosed += Keranjang_FormClosed;
                keranjang.MdiParent = this;
                keranjang.Dock = DockStyle.Fill;
                keranjang.Show();
            }
            else
            {
                keranjang.Activate();
            }
        }

        private void Keranjang_FormClosed(object? sender, FormClosedEventArgs e)
        {
            keranjang = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (subMahar == null)
            {
                subMahar = new SubMahar();
                subMahar.FormClosed += SubMahar_FormClosed;
                subMahar.MdiParent = this;
                subMahar.Dock = DockStyle.Fill;
                subMahar.Show();
            }
            else
            {
                subMahar.Activate();
            }
        }

        private void SubMahar_FormClosed(object? sender, FormClosedEventArgs e)
        {
            subMahar = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (subSeserahan == null)
            {
                subSeserahan = new SubSeserahan();
                subSeserahan.FormClosed += SubSeserahan_FormClosed;
                subSeserahan.MdiParent = this;
                subSeserahan.Dock = DockStyle.Fill;
                subSeserahan.Show();
            }
            else
            {
                subSeserahan.Activate();
            }
        }

        private void SubSeserahan_FormClosed(object? sender, FormClosedEventArgs e)
        {
            subSeserahan = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (subSuvernir == null)
            {
                subSuvernir = new SubSuvernir();
                subSuvernir.FormClosed += SubSuvernir_FormClosed;
                subSuvernir.MdiParent = this;
                subSuvernir.Dock = DockStyle.Fill;
                subSuvernir.Show();
            }
            else
            {
                subSuvernir.Activate();
            }
        }

        private void SubSuvernir_FormClosed(object? sender, FormClosedEventArgs e)
        {
            subSuvernir = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (aboutUs == null)
            {
                aboutUs = new AboutUs();
                aboutUs.FormClosed += AboutUs_FormClosed;
                aboutUs.MdiParent = this;
                aboutUs.Dock = DockStyle.Fill;
                aboutUs.Show();
            }
            else
            {
                aboutUs.Activate();
            }
        }

        private void AboutUs_FormClosed(object? sender, FormClosedEventArgs e)
        {
            aboutUs = null;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Show();
        }

    }
}
