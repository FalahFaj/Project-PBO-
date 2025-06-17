using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using debugging.Model;
using debugging.DAL;
using debugging.PenghubungDB;
using debugging.Service;

namespace debugging
{
    public partial class Regis : Form
    {
        private readonly ServiceAkun serviceAkun;
        public Regis()
        {
            InitializeComponent();

            var koneksiDB = new KoneksiDB();
            var akses_customer = new Akses_customer(koneksiDB);
            serviceAkun = new ServiceAkun(akses_customer);
        }
        public class Kevalidan_regis
        {
            public string Email { get; set; }
            public string Nama { get; set; }
            public string NoHp { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }

            public Kevalidan_regis(string email, string nama, string no_hp, string username, string password)
            {
                Email = email?.Trim() ?? "";
                Nama = nama?.Trim() ?? "";
                NoHp = no_hp?.Trim() ?? "";
                Username = username?.Trim() ?? "";
                Password = password?.Trim() ?? "";
            }
            public bool EmailValid()
            {
                return (Email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) ||
                        Email.EndsWith("@mail.unej.ac.id", StringComparison.OrdinalIgnoreCase));
            }
            public bool NamaValaid()
            {
                return !string.IsNullOrEmpty(Nama) && Nama.Length >= 3;
            }
            public bool NoHpValid()
            {
                return !string.IsNullOrEmpty(NoHp) && (NoHp.Length >= 10 && NoHp.Length <= 13) && NoHp.All(char.IsDigit) && NoHp.StartsWith("62");
            }
            public bool UsernameValid()
            {
                return !string.IsNullOrEmpty(Username) && Username.Length >= 3;
            }
            public bool PasswordValid()
            {
                return !string.IsNullOrEmpty(Password) && Password.Length >= 8 &&
                       Password.Any(char.IsLower) && Password.Any(char.IsDigit);
            }
            public bool SemuaValid()
            {
                return EmailValid() && NamaValaid() && NoHpValid() && UsernameValid() && PasswordValid();
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login(this.serviceAkun);
            login.ShowDialog();
            this.Show();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            var pengecek = new Kevalidan_regis(
                textBox2.Text,
                textBox1.Text,
                box_No_Hp.Text,
                textBox3.Text,
                textBox4.Text
            );
            if (!pengecek.SemuaValid())
            {
                MessageBox.Show("Mohon periksa kembali data yang Anda masukkan.", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var customer = new Customer
            {
                email_address = pengecek.Email,
                nama = pengecek.Nama,
                no_hp = pengecek.NoHp,
                username = pengecek.Username,
                password = pengecek.Password
            };

            try
            {
                if (serviceAkun.Register(customer))
                {
                    MessageBox.Show("Registrasi Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();    
                    Login login = new Login(this.serviceAkun);
                    login.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username atau Email sudah terdaftar", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat registrasi: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
