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

namespace debugging
{
    public partial class DashboardUser : Form
    {
        AboutUs aboutUs;
        Keranjang keranjang;
        private readonly ServiceProduk serviceProduk;
        private readonly ServiceAkun serviceAkun;
        private readonly UserLogin akun;
        private System.Windows.Forms.Timer produkTimer;
        private SubMahar subMaharForm;
        private SubSeserahan subSeserahanForm;
        private SubSuvernir subSuvernirForm;
        private Keranjang_ini keranjang_ini;
        private Dictionary<int, Image> imageCache = new();
        public DashboardUser(ServiceAkun serviceAkun, UserLogin akun)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.serviceAkun = serviceAkun;
            this.akun = akun;
            PanelchatAdmin.Visible = false;

            KoneksiDB koneksiDB = new KoneksiDB();
            IAksesProduk aksesproduk = new AksesProduk(koneksiDB);
            this.serviceProduk = new ServiceProduk(aksesproduk);

            keranjang_ini = new Keranjang_ini(akun);
            subMaharForm = new SubMahar(serviceProduk);
            subSeserahanForm = new SubSeserahan(serviceProduk);
            subSuvernirForm = new SubSuvernir(serviceProduk);

            subMaharForm.TopLevel = false;
            subMaharForm.FormBorderStyle = FormBorderStyle.None;
            subMaharForm.Dock = DockStyle.Fill;
            flowLayoutPanel3.Controls.Add(subMaharForm);

            subSeserahanForm.TopLevel = false;
            subSeserahanForm.FormBorderStyle = FormBorderStyle.None;
            subSeserahanForm.Dock = DockStyle.Fill;
            flowLayoutPanel3.Controls.Add(subSeserahanForm);

            subSuvernirForm.TopLevel = false;
            subSuvernirForm.FormBorderStyle = FormBorderStyle.None;
            subSuvernirForm.Dock = DockStyle.Fill;
            flowLayoutPanel3.Controls.Add(subSuvernirForm);


            produkTimer = new System.Windows.Forms.Timer();
            produkTimer.Interval = 1000;
            produkTimer.Tick += ProdukTimer_Tick;
            produkTimer.Start();
        }
        private void ProdukTimer_Tick(object sender, EventArgs e)
        {
            produkTimer.Stop();
            LoadProducts(serviceProduk);
        }
        private Image FotoProdukCached(Produk produk)
        {
            if (produk == null) return null;
            if (imageCache.TryGetValue(produk.id_produk, out var img))
                return img;
            var image = FotoProduk(produk.foto);
            if (image != null)
                imageCache[produk.id_produk] = image;
            return image;
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
                    FotoProduk = FotoProdukCached(item),
                    Margin = new Padding(10, 10, 10, 10),
                    Tag = item
                };
                kartu.Padding = new Padding(5);
                kartu.Width = 170;
                kartu.Height = 300;
                kartu.Click += Kartu_Click;
                foreach (Control control in kartu.Controls)
                {
                    control.Click += (sender, e) => Kartu_Click(kartu, e);
                }
                flowLayoutPanel3.Controls.Add(kartu);
            }
        }
        private void Kartu_Click(object sender, EventArgs e)
        {
            if (sender is KotakProduk kartu && kartu.Tag is Produk produk)
            {
                if (produk != null)
                {
                    DetailProduk detailProduk = new DetailProduk(produk, akun, serviceAkun);
                    detailProduk.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Produk tidak ditemukan.");
                }
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

                return FotoDefault.GetFotoDefault();
            }
            catch
            {
                // Log or handle the exception if necessary  
            }

            return null;
        }

        bool menuExpand = false;
        bool sidebarExpand = true;
        private object proudukTimer;

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
            if (keranjang_ini == null)
            {
                flowLayoutPanel1.Hide();
                flowLayoutPanel2.Hide();
                flowLayoutPanel3.Hide();
                keranjang_ini = new Keranjang_ini(akun);
                keranjang_ini.BringToFront();
                keranjang_ini.FormClosed += Keranjang_FormClosed;
                keranjang_ini.MdiParent = this;
                keranjang_ini.Dock = DockStyle.Fill;
                keranjang_ini.Show();
            }
            else
            {
                keranjang_ini.Activate();
            }
        }

        private void Keranjang_FormClosed(object? sender, FormClosedEventArgs e)
        {
            keranjang_ini = null;
        }
        private void Tampilkan_Produk_Berdasar_Kategori(int id_kategori)
        {
            flowLayoutPanel3.Controls.Clear();
            var produks = serviceProduk.GetAllProduk()
                .Where(p => p.id_kategori == id_kategori)
                .ToList();
            foreach (var item in produks)
            {
                var kartu = new KotakProduk
                {
                    NamaProduk = item.nama,
                    HargaProduk = item.harga,
                    FotoProduk = FotoProdukCached(item),
                    Margin = new Padding(10, 10, 10, 10),
                    Tag = item
                };
                kartu.Padding = new Padding(5);
                kartu.Width = 170;
                kartu.Height = 300;
                kartu.Click += Kartu_Click;
                foreach (Control control in kartu.Controls)
                {
                    control.Click += (sender, e) => Kartu_Click(kartu, e);
                }
                flowLayoutPanel3.Controls.Add(kartu);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            subSeserahanForm.Hide();
            subSuvernirForm.Hide();
            subMaharForm.Show();
            subMaharForm.BringToFront();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            subMaharForm.Hide();
            subSuvernirForm.Hide();
            subSeserahanForm.Show();
            subSeserahanForm.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            subMaharForm.Hide();
            subSeserahanForm.Hide();
            subSuvernirForm.Show();
            subSuvernirForm.BringToFront();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (aboutUs == null)
            {
                flowLayoutPanel1.Hide();
                flowLayoutPanel2.Hide();
                flowLayoutPanel3.Hide();
                aboutUs = new AboutUs(akun);
                aboutUs.FormClosed += AboutUs_FormClosed;
                aboutUs.BringToFront();
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

        private void DashboardUser_Load(object sender, EventArgs e)
        {

        }

        private void TombolBukaChat_Click(object sender, EventArgs e)
        {
            PanelchatAdmin.Visible = !PanelchatAdmin.Visible;

        }
    }
}
