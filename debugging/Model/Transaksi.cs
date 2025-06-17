using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_PBO_Kel_5.Model;

namespace debugging.Model
{
    public class Transaksi
    {
        [Key]
        public int id_transaksi { get; set; }
        public DateTime tanggal { get; set; }
        public decimal nominal { get; set; }
        [ForeignKey("id_customer")]
        public int id_customer { get; set; }
        [ForeignKey("id_metode_pembayaran")]
        public int id_metode_pembayaran { get; set; }
        [ForeignKey("id_penyewaan")]
        public int? id_penyewaan { get; set; }
        [ForeignKey("id_jenis_transaksi")]
        public int id_jenis_transaksi { get; set; }
        public string status { get; set; }   
        public decimal Total { get; set; }
        public Customer customer { get; set; }
        public Jenis_transaksi jenis_transaksi { get; set; }
        public Penyewaan Penyewaan { get; set; }
        public Metode_pembayaran MetodePembayaran { get; set; }
    }
}
