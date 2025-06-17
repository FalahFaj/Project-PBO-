using System;
using System.Windows.Forms;
using debugging.Service;
using debugging.Model;

namespace debugging
{
    public partial class Login : Form
    {
        public UserLogin LoggedInUser { get; private set; }
        private readonly ServiceAkun serviceAkun;

        public Login(ServiceAkun serviceAkun)
        {
            InitializeComponent();
            this.serviceAkun = serviceAkun;
            //this.pictureBox3.Click += new System.EventHandler(this.btnLogin_Click);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            using (Regis regis = new Regis())
            {
                regis.ShowDialog();
            }
            this.Show(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text.Trim();
            string password = textBox3.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong.", "Peringatan");
                return;
            }

            try
            {
                var akun = serviceAkun.Login(username, password);

                if (akun != null)
                {
                   
                    this.LoggedInUser = akun;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah.", "Kesalahan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error");
            }
        }
    }
}