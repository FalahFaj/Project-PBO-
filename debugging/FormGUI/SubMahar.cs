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
    public partial class SubMahar : Form
    {
        private readonly ServiceProduk serviceProduk;

        public SubMahar(ServiceProduk serviceProduk)
        {
            InitializeComponent(); 
            this.serviceProduk = serviceProduk;
            var produkMahar = serviceProduk.GetAllProduk().Where(p => p.id_kategori == 3).ToList();
        }

        private void SubMahar_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
