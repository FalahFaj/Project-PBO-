using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debugging
{
    public partial class ChatUser : UserControl
    {
        public int Id_customer { get; set; }

        public ChatUser(string namaUser, string pesanTerakhir, DateTime waktuTerakhir, int id_customer)
        {
            InitializeComponent();

            lblNamaUser.Text = namaUser;
            lblPesanTerakhir.Text = pesanTerakhir;
            lblWaktu.Text = waktuTerakhir.ToLocalTime().ToString("HH:mm");
            Id_customer = id_customer;
        }
        public void KlikSemua(EventHandler clickHandler)
        {
            this.Click += clickHandler;
            foreach (Control kontrol in this.Controls)
            {
                kontrol.Click += clickHandler;
            }
        }
        private void ChatUser_Load(object sender, EventArgs e)
        {

        }
    }
}
