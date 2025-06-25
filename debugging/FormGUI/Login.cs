using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using debugging.PenghubungDB;
using debugging.DAL;
using debugging.Service;

namespace debugging
{
    public partial class Login : Form
    {
        private readonly ServiceAkun serviceAkun;
        private readonly Akses_customer akses_customer;
        public Login()
        {
            InitializeComponent();

            var koneksiDB = new KoneksiDB();
            var akses_customer = new Akses_customer(koneksiDB);
            serviceAkun = new ServiceAkun(akses_customer);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Regis regis = new Regis();
            regis.ShowDialog();
            this.Hide();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            string username = textBox2.Text.Trim();
            string password = textBox3.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var akun = serviceAkun.Login(username, password);
            if (akun != null)
            {
                if (akun.Role == "Admin")
                {
                    MessageBox.Show("Login Berhasil sebagai Admin", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    dashboard_admin2 dashboard = new dashboard_admin2(serviceAkun, akun);
                    dashboard.ShowDialog();
                    this.Close();
                }
                else if (akun.Role == "Customer")
                {
                    MessageBox.Show("Login Berhasil sebagai User", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    DashboardUser dashboardUser = new DashboardUser(serviceAkun, akun);
                    dashboardUser.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Role tidak dikenali", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username atau Password salah", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                linkLupaPass.Visible = true;
            }
        }
        private void linkLupaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false;
            pnlLupaPass.Visible = true;
            pnlLupaPass.BringToFront();
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            string email = txtEmailLupa.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string emailDB = serviceAkun.GetEmail(email);
            if (emailDB != null && emailDB.Equals(email, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Email ditemukan. Silakan masukkan password baru.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassBaru.Visible = true;
                txtPassBaru.Enabled = true;
                pictureBox8.Visible = true;
                btnNewPass.Visible = true;
            }
            else
            {
                MessageBox.Show("Email tidak terdaftar.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewPass_Click(object sender, EventArgs e)
        {
            string email = txtEmailLupa.Text.Trim();
            string newPassword = txtPassBaru.Text.Trim();
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Password baru tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bool sukses = serviceAkun.UpdatePassword(email, newPassword);
                if (sukses)
                {
                    MessageBox.Show("Password berhasil diubah. Silakan login kembali.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlLupaPass.Visible = false;
                    panel1.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengubah password. {ex.Message}.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            pnlLupaPass.Visible = false;
            panel1.Visible = true;
        }
    }
}