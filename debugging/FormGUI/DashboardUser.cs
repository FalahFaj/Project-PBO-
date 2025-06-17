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
        private Keranjang_ini keranjang_ini;
        private Dictionary<int, Image> imageCache = new();
        public DashboardUser(ServiceAkun serviceAkun, UserLogin akun)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.serviceAkun = serviceAkun;
            this.akun = akun;
            this.Controls.Add(PanelchatAdmin);
            PanelchatAdmin.Visible = false;

            KoneksiDB koneksiDB = new KoneksiDB();
            IAksesProduk aksesproduk = new AksesProduk(koneksiDB);
            this.serviceProduk = new ServiceProduk(aksesproduk);

            //subMaharForm = new SubMahar(serviceProduk);
            //subSeserahanForm = new SubSeserahan(serviceProduk);
            //subSuvernirForm = new SubSuvernir(serviceProduk);

            //subMaharForm.TopLevel = false;
            //subMaharForm.FormBorderStyle = FormBorderStyle.None;
            //subMaharForm.Dock = DockStyle.Fill;
            //flowLayoutPanel3.Controls.Add(subMaharForm);

            //subSeserahanForm.TopLevel = false;
            //subSeserahanForm.FormBorderStyle = FormBorderStyle.None;
            //subSeserahanForm.Dock = DockStyle.Fill;
            //flowLayoutPanel3.Controls.Add(subSeserahanForm);

            //subSuvernirForm.TopLevel = false;
            //subSuvernirForm.FormBorderStyle = FormBorderStyle.None;
            //subSuvernirForm.Dock = DockStyle.Fill;
            //flowLayoutPanel3.Controls.Add(subSuvernirForm);

            // Tambahkan ke Controls form utama jika belum
            if (!this.Controls.Contains(PanelchatAdmin))
                this.Controls.Add(PanelchatAdmin);

            // Atur ukuran panel chat admin
            PanelchatAdmin.Size = new Size(308, 507);

            // Atur posisi di kanan bawah
            PanelchatAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PanelchatAdmin.Location = new Point(
                this.ClientSize.Width - PanelchatAdmin.Width - 20, // 20 = margin dari kanan
                this.ClientSize.Height - PanelchatAdmin.Height - 20 // 20 = margin dari bawah
            );

            // Pastikan panel tetap di posisi saat resize
            this.Resize += (s, e) =>
            {
                PanelchatAdmin.Location = new Point(
                    this.ClientSize.Width - PanelchatAdmin.Width - 20,
                    this.ClientSize.Height - PanelchatAdmin.Height - 20
                );
            };

            produkTimer = new System.Windows.Forms.Timer();
            produkTimer.Interval = 1000;
            produkTimer.Tick += ProdukTimer_Tick;
            produkTimer.Start();
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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

        private static Image FotoProduk(string filePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(filePath) && System.IO.File.Exists(filePath))
                {
                    return Image.FromFile(filePath);
                }

                return FotoDefault.GetFotoDefault();
            }
            catch
            {
                // Log or handle the exception if necessary  
            }

            return null;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesan.Text))
            {
                btnSend.Enabled = false;
            }
            using (var db = new KoneksiDB())
            {
                var chat = new Data_chat
                {
                    id_customer = akun.Id,
                    pesan = txtPesan.Text,
                    admin = false,
                    waktu_dikirim = DateTime.UtcNow,
                    foto = null
                };
                db.data_chat.Add(chat);
                db.SaveChanges();
            }
            txtPesan.Clear();
            Load_Chat();
        }
        private void Load_Chat()
        {
            flpChat.Controls.Clear();
            using (KoneksiDB chat_db = new KoneksiDB())
            {
                var Data_chat = chat_db.data_chat
                    .Where(c => c.id_customer == akun.Id)
                    .OrderBy(c => c.waktu_dikirim)
                    .ToList();
                foreach (var chat in Data_chat)
                {
                    if (chat == null)
                        continue;
                    bool dariAdmin = chat.admin;
                    string pesan = chat.pesan ?? "";
                    DateTime waktu = chat.waktu_dikirim.ToLocalTime();
                    Gelembung_chat gelembungChat = new Gelembung_chat(pesan, dariAdmin, waktu);
                    if (dariAdmin)
                    {
                        var wrapper = gelembungChat.GetWrappedPanel(flpChat.ClientSize.Width, true);
                    }
                    else
                    {
                        var wrapper = gelembungChat.GetWrappedPanel(flpChat.ClientSize.Width, false);
                    }
                    gelembungChat.Margin = new Padding(0, 0, 0, 10);
                    gelembungChat.Dock = DockStyle.Top;
                    gelembungChat.AutoSize = true;
                    flpChat.Controls.Add(gelembungChat);
                    flpChat.ScrollControlIntoView(gelembungChat);
                }
            }
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
            TampilkanSemula();
            flowLayoutPanel3.Controls.Clear();
            LoadProducts(serviceProduk);
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
                flowLayoutPanel3.Hide();
                keranjang_ini = new Keranjang_ini(akun,serviceAkun);
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
            TampilkanSemula();
            Tampilkan_Produk_Berdasar_Kategori(3);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TampilkanSemula();
            Tampilkan_Produk_Berdasar_Kategori(4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TampilkanSemula();
            Tampilkan_Produk_Berdasar_Kategori(1);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (aboutUs == null)
                {
                    foreach (Form child in this.MdiChildren)
                    {
                        child.Close();
                    }
                    flowLayoutPanel3.Hide();
                    aboutUs = new AboutUs(akun);
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
            catch (Exception ex)
            {
                MessageBox.Show("Gagal kembali", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            btnSend.Click += btnSend_Click;
            Load_Chat();
        }

        private void TombolBukaChat_Click(object sender, EventArgs e)
        {
            
        }
        private void TampilkanSemula()
        {
            if (aboutUs != null)
            {
                aboutUs.Close();
                aboutUs = null;
            }
            if (keranjang_ini != null)
            {
                keranjang_ini.Close();
                keranjang_ini = null;
            }
            flowLayoutPanel3.Show();
        }

        private void TombolBukaChat_Click_1(object sender, EventArgs e)
        {
            PanelchatAdmin.Visible = !PanelchatAdmin.Visible;
            PanelchatAdmin.BringToFront();
        }
    }
}
