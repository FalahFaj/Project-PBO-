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
using debugging.Model;
using debugging.Service;
using debugging.AksesLayer;
using debugging.DAL;
using Project_PBO_Kel_5.Model;
using debugging.PenghubungDB;

namespace debugging
{
    public partial class Pembayaran : Form
    {
        private bool sidebarexpand;
        private Panel sidebar = new Panel();
        private System.Windows.Forms.Timer sidebarTimer;
        private ServiceAkun serviceAkun;
        private UserLogin userLogin;
        private Akses_customer aksesCustomer;
        private Produk produk;
        private List<Metode_pembayaran> metode_pembayaran;

        public Pembayaran(Produk produk, ServiceAkun serviceAkun, UserLogin userLogin)
        {
            InitializeComponent();
            SidebarContainer.Visible = true;
            this.produk = produk;
            this.serviceAkun = serviceAkun;
            this.userLogin = userLogin;
        }
        public Pembayaran(ServiceAkun serviceAkun, UserLogin userLogin)
        {
            InitializeComponent();
            SidebarContainer.Visible = true;
            this.serviceAkun = serviceAkun;
            this.userLogin = userLogin;
            this.produk = null;
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

            using (var db = new KoneksiDB())
            {
                metode_pembayaran = db.metode_pembayaran.ToList();
            }
            comboBox1.Items.Clear();
            foreach (var metode in metode_pembayaran)
            {
                comboBox1.Items.Add(metode.metode_pembayaran);
            }
            if (produk != null)
            {
                GridViewProduk.Visible = false;
                lblProduk.Text = produk.nama;
                lblHarga.Text = $"Rp {produk.harga:N0}";
                numericUpDown1.Minimum = 1;
                numericUpDown1.Maximum = produk.stok;
                numericUpDown1.Value = 1;
                lblTotal.Text = $"Rp {produk.harga:N0}";
            }
            else
            {
                GridViewProduk.Visible = true;
                using (var db = new KoneksiDB())
                {
                    var idUser = userLogin.Id;
                    var keranjang = db.keranjang.Where(k => k.id_customer == idUser).ToList();
                    if (keranjang != null)
                    {
                        var detailKeranjang = db.detail_keranjang
                            .Where(dk => keranjang.Any(k => k.id_keranjang == dk.id_keranjang))
                            .ToList();
                        var produkList = (from dk in detailKeranjang
                                          join p in db.produk on dk.id_produk equals p.id_produk
                                          select new
                                          {
                                              kolomBarang = p.nama,
                                              kolomHarga = p.harga,
                                              kolomJumlah = dk.jumlah,
                                          }).ToList();
                        GridViewProduk.DataSource = produkList;
                        decimal total = produkList.Sum(p => p.kolomHarga * p.kolomJumlah);
                        lblTotal.Text = $"Rp {total:N0}";
                    }
                }
            }
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
            DashboardUser form = new DashboardUser(serviceAkun, userLogin);
            form.ShowDialog();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                lblNorek.Enabled = true;
                string pilihan = comboBox1.SelectedItem.ToString();
                var metode = metode_pembayaran.FirstOrDefault(m => m.metode_pembayaran == pilihan);
                if (metode != null)
                {
                    lblNorek.Text = metode.no_rekening;
                }
                else
                {
                    lblNorek.Text = "-";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new KoneksiDB())
            {
                int idCustomer = userLogin.Id;
                int idMetode = 0;
                Metode_pembayaran metode = null;

                if (comboBox1.SelectedItem != null)
                {
                    metode = metode_pembayaran.FirstOrDefault(m => m.metode_pembayaran == comboBox1.SelectedItem.ToString());
                    if (metode != null)
                    {
                        idMetode = metode.id_metode_pembayaran;
                    }
                }

                if (idMetode == 0)
                {
                    MessageBox.Show("Pilih metode Pembayaran terlebih dahulu");
                    return;
                }

                var transaksi = new Transaksi
                {
                    tanggal = DateTime.UtcNow,
                    nominal = 0,
                    id_customer = idCustomer,
                    id_metode_pembayaran = idMetode,
                    id_jenis_transaksi = 1
                };
                db.transaksi.Add(transaksi);
                db.SaveChanges();

                decimal total = 0;
                if (produk != null)
                {
                    var item = new Item_transaksi
                    {
                        id_item_transaksi = 0,
                        id_produk = produk.id_produk,
                        jumlah = 1,
                        id_transaksi = transaksi.id_transaksi
                    };
                    db.item_transaksi.Add(item);
                    total = produk.harga;
                    transaksi.nominal = total;
                    db.SaveChanges();
                    var result = MessageBox.Show(
                        "Pembelian berhasil.\nApakah Anda ingin mencetak struk?",
                        "Cetak Struk",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        debugging.Service.Cetak_Struk.BuatStrukPembelian(
                            userLogin.Name,
                            produk.nama,
                            (int)numericUpDown1.Value,
                            total,
                            transaksi.tanggal,
                            metode.metode_pembayaran,
                            metode.no_rekening
                        );
                        MessageBox.Show($"Struk berhasil dicetak ke file struk_pemmbelian.pdf dan disimpan di {Environment.CurrentDirectory}");
                    }
                    this.Close();
                }
                else
                {
                    var keranjang = db.keranjang.FirstOrDefault(k => k.id_customer == idCustomer);
                    if (keranjang != null)
                    {
                        var detailKeranjang = db.detail_keranjang
                            .Where(dk => dk.id_keranjang == keranjang.id_keranjang)
                            .ToList();
                        foreach (var dk in detailKeranjang)
                        {
                            var produkItem = db.produk.FirstOrDefault(p => p.id_produk == dk.id_produk);
                            if (produkItem != null)
                            {
                                var item = new Item_transaksi
                                {
                                    id_item_transaksi = 0,
                                    id_produk = produkItem.id_produk,
                                    jumlah = dk.jumlah,
                                    id_transaksi = transaksi.id_transaksi
                                };
                                db.item_transaksi.Add(item);
                                total += produkItem.harga * dk.jumlah;
                            }
                        }
                    }
                    transaksi.nominal = total;
                    db.SaveChanges();
                    db.detail_keranjang.RemoveRange(db.detail_keranjang.Where(dk => dk.id_keranjang == keranjang.id_keranjang));
                    db.keranjang.Remove(keranjang);
                    db.SaveChanges();
                    MessageBox.Show($"Pembayaran berhasil. Total: Rp {total:N0}");
                    this.Close();
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (produk != null)
            {
                decimal jumlah = numericUpDown1.Value;
                decimal total = produk.harga * jumlah;
                lblTotal.Text = $"Rp {total:N0}";
            }
        }

        public static implicit operator Pembayaran(Panel v)
        {
            throw new NotImplementedException();
        }
    }
}
