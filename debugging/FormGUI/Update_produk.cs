using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using debugging.Service;
using debugging.Model;
using debugging.PenghubungDB;
using debugging.AksesLayer;

namespace debugging
{
    public partial class update_Produk : Form
    {
        private readonly ServiceProduk serviceProduk;
        private readonly AksesLayer.IAksesProduk aksesProduk;
        private Produk produkTerpilih;
        public update_Produk(ServiceProduk serviceProduk)
        {
            InitializeComponent();
            this.serviceProduk = serviceProduk ?? throw new ArgumentNullException(nameof(serviceProduk));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            comboBoxkategori.Items.AddRange(new string[] { "Nama", "Harga", "Stok", "Disewakan" });
        }

        private void update_Produk_Load(object sender, EventArgs e)
        {
            comboBoxkategori.Items.AddRange(new string[] { "Nama", "Harga", "Stok", "Disewakan" });

            comboBoxKategoriUpdate.DataSource = GetAllKategori();
            comboBoxKategoriUpdate.DisplayMember = "kategori";
            comboBoxKategoriUpdate.ValueMember = "id_kategori";
            comboBoxKategoriUpdate.Enabled = false;
        }
        private List<Kategori> GetAllKategori()
        {
            using (var db = new KoneksiDB())
            {
                return db.kategori.ToList();
            }
        }
        private void comboBoxkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKategoriUpdate.Enabled = comboBoxkategori.SelectedItem?.ToString() == "Kategori";
            textBoxUpdateValue.Enabled = comboBoxkategori.SelectedItem?.ToString() != "Kategori";
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblCari_id.Text, out int id))
            {
                produkTerpilih = serviceProduk.GetProdukBById(id);
                if (produkTerpilih != null)
                {
                    tampilkan_id_grid.DataSource = new List<Produk> { produkTerpilih };
                }
                else
                {
                    MessageBox.Show("Produk tidak ditemukan.");
                    tampilkan_id_grid.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("ID produk harus berupa angka.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (produkTerpilih == null)
            {
                MessageBox.Show("Cari produk terlebih dahulu.");
                return;
            }

            string field = comboBoxkategori.SelectedItem?.ToString();

            try
            {
                switch (field)
                {
                    case "Nama":
                        produkTerpilih.nama = textBoxUpdateValue.Text;
                        break;
                    case "Harga":
                        produkTerpilih.harga = decimal.Parse(textBoxUpdateValue.Text);
                        break;
                    case "Stok":
                        produkTerpilih.stok = int.Parse(textBoxUpdateValue.Text);
                        break;
                    case "Disewakan":
                        produkTerpilih.disewakan = textBoxUpdateValue.Text.ToLower() == "ya" || textBoxUpdateValue.Text.ToLower() == "true";
                        break;
                    case "Kategori":
                        produkTerpilih.id_kategori = (int)comboBoxKategoriUpdate.SelectedValue;
                        break;
                    default:
                        MessageBox.Show("Pilih field yang ingin diupdate.");
                        return;
                }
                aksesProduk.UpdateProduk(produkTerpilih);

                tampilkan_id_grid.DataSource = new List<Produk> { produkTerpilih };
                MessageBox.Show("Produk berhasil diupdate.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal update: {ex.Message}");
            }
        }
    }
}