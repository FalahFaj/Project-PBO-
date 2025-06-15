using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using debugging.Model;

namespace Project_PBO_Kel_5.Model
{
    public class Metode_pembayaran
    {
        [Key]
        public int id_metode_pembayaran { get; set; }
        public string metode_pembayaran { get; set; }
        public string no_rekening { get; set; }
        public ICollection<Transaksi> MetodePembayaran { get; set; }

    }
}
