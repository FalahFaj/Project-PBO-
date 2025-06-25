using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging.Model
{
    public class RiwayatViewModel
    {
        public string Tipe { get; set; }
        public int IdTransaksi { get; set; }
        public string NamaPelanggan { get; set; }
        public DateTime Tanggal { get; set; }
        public string KeteranganProduk { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
    }
}
