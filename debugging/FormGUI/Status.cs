using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using debugging.Model;
using debugging.PenghubungDB;
using debugging.Service;

namespace debugging
{
    public partial class Status : Form
    {
        private List<RiwayatViewModel> semuaTransaksi;
        private readonly IServiceRiwayat serviceRiwayat;

        public Status(IServiceRiwayat serviceRiwayat)
        {
            InitializeComponent();
            this.serviceRiwayat = serviceRiwayat;
            this.Load += new System.EventHandler(this.Status_Load);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
        }
        private void Status_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            comboBox1.Items.AddRange(new object[] { "Semua", "Sewa", "Beli" });
            comboBox1.SelectedIndex = 0;
            LoadSemuaTransaksi();
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#3F51B5");
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoGenerateColumns = false; 

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tipe", DataPropertyName = "Tipe", FillWeight = 50 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "IdTransaksi", FillWeight = 40 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nama Pelanggan", DataPropertyName = "NamaPelanggan", FillWeight = 120 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tanggal", DataPropertyName = "Tanggal", DefaultCellStyle = { Format = "dd-MM-yyyy" }, FillWeight = 80 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Keterangan", DataPropertyName = "KeteranganProduk", FillWeight = 150 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Total", DataPropertyName = "Total", DefaultCellStyle = { Format = "C0", Alignment = DataGridViewContentAlignment.MiddleRight }, FillWeight = 90 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status", FillWeight = 70 });
        }

        private void LoadSemuaTransaksi()
        {
            try
            {
                using (var db = new KoneksiDB())
                {
                    var riwayatSewa = (from p in db.penyewaan
                                       join c in db.customer on p.id_customer equals c.id_customer
                                       join d in db.item_penyewaan on p.id_penyewaan equals d.id_penyewaan
                                       join pr in db.produk on d.id_produk equals pr.id_produk
                                       select new RiwayatViewModel
                                       {
                                           Tipe = "Sewa",
                                           IdTransaksi = p.id_penyewaan,
                                           NamaPelanggan = c.nama,
                                           Tanggal = p.tanggal_sewa,
                                           KeteranganProduk = pr.nama,
                                           Status = p.status_peminjaman,
                                           Total = d.jumlah * pr.harga
                                       }).ToList();
                    var riwayatBeli = (from t in db.transaksi
                                       join c in db.customer on t.id_customer equals c.id_customer
                                       where t.id_jenis_transaksi == 2
                                       select new RiwayatViewModel
                                       {
                                           Tipe = "Beli",
                                           IdTransaksi = t.id_transaksi,      
                                           NamaPelanggan = c.nama,
                                           Tanggal = t.tanggal,          
                                           KeteranganProduk = "Pembelian Produk",    
                                       }).ToList();

                    semuaTransaksi = riwayatSewa.Concat(riwayatBeli).ToList();

                    dataGridView1.DataSource = semuaTransaksi.OrderByDescending(t => t.Tanggal).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat riwayat transaksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (semuaTransaksi == null) return;
            string filter = comboBox1.SelectedItem.ToString();
            List<RiwayatViewModel> dataTersaring;

            if (filter == "Semua")
            {
                dataTersaring = semuaTransaksi;
            }
            else
            {
                dataTersaring = semuaTransaksi.Where(t => t.Tipe == filter).ToList();
            }

            dataGridView1.DataSource = dataTersaring.OrderByDescending(t => t.Tanggal).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}