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

namespace debugging.FormGUI
{
    public partial class Tambah_produk : Form
    {
        private readonly ServiceProduk serviceProduk;
        private readonly AksesLayer.IAksesProduk aksesProduk;
        public Tambah_produk(ServiceProduk serviceProduk, AksesLayer.IAksesProduk aksesProduk)
        {
            InitializeComponent();
            this.serviceProduk = serviceProduk;
            this.aksesProduk = aksesProduk;
        }

        private void Tambah_produk_Load(object sender, EventArgs e)
        {
            comboKategori.DataSource = GetAllNamaKategori();
            comboKategori.DisplayMember = "kategori";
            comboKategori.ValueMember = "id_kategori";

            comboDisewakan.DataSource = new List<string> { "Ya", "Tidak" };
        }
        private List<string> GetAllNamaKategori()
        {
            using (var db = new KoneksiDB())
            {
                return db.kategori.Select(k => k.kategori).ToList();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                var produk = new Produk
                {
                    nama = boxNamaProduk.Text,
                    harga = decimal.Parse(boxHarga.Text),
                    stok = int.Parse(boxStok.Text),
                    id_kategori = (int)comboKategori.SelectedValue,
                    disewakan = comboDisewakan.SelectedItem.ToString() == "Ya"
                };

                serviceProduk.TambahProduk(produk);
                MessageBox.Show("Produk berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menambah produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
