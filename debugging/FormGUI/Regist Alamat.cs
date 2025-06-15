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

namespace debugging
{
    public partial class Regist_Alamat : Form
    {
        private UserLogin akun;
        public Regist_Alamat(UserLogin akun)
        {
            InitializeComponent();
            this.akun = akun;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(boxProvinsi.Text) ||
                string.IsNullOrWhiteSpace(boxKota.Text) ||
                string.IsNullOrWhiteSpace(boxKec.Text) ||
                string.IsNullOrWhiteSpace(boxKelurahan.Text) ||
                string.IsNullOrWhiteSpace(boxRw.Text) ||
                string.IsNullOrWhiteSpace(boxRt.Text))
            {
                MessageBox.Show("Semua kolom harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var db = new KoneksiDB())
                {
                    var customer = db.customer.FirstOrDefault(c => c.id_customer == akun.Id);
                    if (customer != null)
                    {
                        customer.rt = boxRt.Text;
                        customer.rw = boxRw.Text;
                        customer.kelurahan = boxKelurahan.Text;
                        customer.kecamatan = boxKec.Text;
                        customer.kota = boxKota.Text;
                        customer.provinsi = boxProvinsi.Text;
                        db.SaveChanges();
                        MessageBox.Show("Alamat berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data pengguna tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
