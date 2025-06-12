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

namespace debugging
{
    public partial class SubSeserahan : Form
    {
        private readonly ServiceProduk serviceProduk;
        public SubSeserahan(ServiceProduk serviceProduk)
        {
            InitializeComponent();
            this.serviceProduk = serviceProduk;
            var produkSeserahan = serviceProduk.GetAllProduk().Where(p => p.id_kategori == 4).ToList();
        }

        private void SubSeserahan_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; 
        }
    }
}
