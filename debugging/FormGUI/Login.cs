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

namespace Project_PBO_Kel_5
{
    public partial class Login : Form
    {
        private readonly ServiceAkun serviceAkun;
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
                    Dashboard_Admin dashboard = new Dashboard_Admin(serviceAkun,akun);
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
            }
        }
    }
}