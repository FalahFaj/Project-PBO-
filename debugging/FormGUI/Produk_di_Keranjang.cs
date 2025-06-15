using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debugging
{
    public partial class Produk_di_Keranjang: UserControl
    {
        public Produk_di_Keranjang()
        {
            InitializeComponent();
        }
        public string NamaProduk
        {
            get { return lblNama.Text; }
            set { lblNama.Text = value; }
        }
        public decimal HargaProduk
        {
            get { return decimal.Parse(lblHarga.Text); }
            set { lblHarga.Text = $"Rp {value:N0}"; }
        }
        public int JumlahProduk
        {
            get { return int.Parse(lblJumlah.Text); }
            set { lblJumlah.Text = value.ToString(); }
        }
        public Image FotoProduk
        {
            get { return fotoProduk.Image; }
            set { fotoProduk.Image = value; }
        }
    }
}
