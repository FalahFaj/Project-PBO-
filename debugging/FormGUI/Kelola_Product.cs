using System;
using System.Linq;
using System.Windows.Forms;
using debugging.Model;
using debugging.Service;
using debugging.FormGUI;

namespace debugging
{
    public partial class Kelola_Product : Form
    {
        private Produk? currentProduk = null;
        private readonly ServiceProduk serviceProduk;
        private int selectedId = -1;

        public Kelola_Product(ServiceProduk serviceProduk)
        {
            InitializeComponent();
            this.serviceProduk = serviceProduk ?? throw new ArgumentNullException(nameof(serviceProduk));

            Load += Kelola_Product_Load;
            btnTambah.Click += btnTambah_Click;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }
        public Kelola_Product(ServiceProduk serviceProduk, Produk produk) : this(serviceProduk)
        {
            SetData(produk);
        }
        private void SetData(Produk produk)
        {
            currentProduk = produk;
            txtNama.Text = produk.nama;
            txtHarga.Text = produk.harga.ToString();
            txtStok.Text = produk.stok.ToString();
        }
        private void Kelola_Product_Load(object? sender, EventArgs e)
        {
            LoadDataProduk();
        }

        private void LoadDataProduk()
        {
            var produkList = serviceProduk.GetAllProduk();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = produkList;
            FormatDataGrid();
        }

        private void FormatDataGrid()
        {
            if (dataGridView1.Columns["id_produk"] != null)
                dataGridView1.Columns["id_produk"].ReadOnly = true;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                if (row.DataBoundItem is Produk produk)
                {
                    selectedId = produk.id_produk;
                    txtNama.Text = produk.nama;
                    txtHarga.Text = produk.harga.ToString();
                    txtStok.Text = produk.stok.ToString();
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
        string.IsNullOrWhiteSpace(txtHarga.Text) ||
        string.IsNullOrWhiteSpace(txtStok.Text))
            {
                MessageBox.Show("Semua field harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtHarga.Text, out decimal harga) || !int.TryParse(txtStok.Text, out int stok))
            {
                MessageBox.Show("Harga dan Stok harus berupa angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var produkBaru = new Produk
            {
                nama = txtNama.Text,
                harga = harga,
                stok = stok,
                id_kategori = 1,
                disewakan = false
            };

            serviceProduk.TambahProduk(produkBaru);
            LoadDataProduk();
            MessageBox.Show("Produk berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataProduk();
            txtNama.Clear();
            txtHarga.Clear();
            txtStok.Clear();
        }
    }
}