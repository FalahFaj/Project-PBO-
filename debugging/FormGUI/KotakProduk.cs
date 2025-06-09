using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debugging.FormGUI
{
    public partial class KotakProduk : UserControl
    {
        public KotakProduk()
        {
            InitializeComponent();
        }
        public string NamaProduk
        {
            get { return labelNamaProduk.Text; }
            set { labelNamaProduk.Text = value; }
        }
        public decimal HargaProduk
        {
            get { return decimal.Parse(labelHargaProduk.Text); }
            set { labelHargaProduk.Text = $"Rp {value:N0}"; }
        }
        public Image FotoProduk
        {
            get { return pictureBoxProduk.Image; }
            set { pictureBoxProduk.Image = value; }
        }
    }
}
