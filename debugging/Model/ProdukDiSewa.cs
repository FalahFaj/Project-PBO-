using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging.Model
{
    public class ProdukDiSewa
    {
        public int IdPenyewaan { get; set; }
        public DateTime TanggalSewa { get; set; }
        public DateTime TanggalKembali { get; set; }
        public string StatusPeminjaman { get; set; }
        public int IdCustomer { get; set; }
        public int IdProduk { get; set; }
        public int Jumlah { get; set; }
        public string NamaProduk { get; set; }
        public string FotoProduk { get; set; }
    }
}
