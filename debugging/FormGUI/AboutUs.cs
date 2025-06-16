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
    public partial class AboutUs : Form
    {
        private UserLogin akun;
        public AboutUs(UserLogin userLogin)
        {
            InitializeComponent();
            this.akun = userLogin;
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
            try
            {
                this.ControlBox = false;
                using (var db = new KoneksiDB())
                {
                    var customer = db.customer.FirstOrDefault(c => c.id_customer == akun.Id);
                    if (customer != null)
                    {
                        lblNama.Text = customer.nama ?? "-";
                        lblEmail.Text = customer.email_address ?? "-";
                        lblNo_HP.Text = customer.no_hp ?? "-";
                        lblUsername.Text = customer.username ?? "-";
                        lblPassword.Text = customer.password ?? "-";
                        if (customer.rt == null && customer.rw == null && customer.kelurahan == null && customer.kecamatan == null && customer.kota == null)
                        {
                            lblAlamat.Text = "Alamat tidak tersedia";
                            var regis = MessageBox.Show(
                                "Alamat Anda belum lengkap. Apakah Anda ingin mengisi alamat sekarang?",
                                "Informasi Alamat",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
                            if (regis == DialogResult.Yes)
                            {
                                this.Hide();
                                Regist_Alamat alamatForm = new Regist_Alamat(akun);
                                alamatForm.ShowDialog();
                                this.BeginInvoke(new Action(() => this.Close()));
                            }
                            else
                            {
                                this.BeginInvoke(new Action(() => this.Close()));
                            }
                        }
                        else
                        {
                            lblAlamat.Text = $"{customer.rt}, {customer.rw}, {customer.kelurahan}, {customer.kecamatan}, {customer.kota}, {customer.provinsi}";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data pengguna tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Gagal mengambil data dari database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
