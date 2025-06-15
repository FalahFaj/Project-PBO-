using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging.Model
{
    public class Penyewaan
    {
        [Key]
        public int id_penyewaan { get; set; }
        public DateTime tanggal_sewa { get; set; }
        public DateTime tanggal_kembali { get; set; }
        public decimal pembayaran_dp { get; set; }
        public string status_dp { get; set; }
        public string status_peminjaman { get; set; }
        [ForeignKey("id_customer")]
        public int id_customer { get; set; }
    }
}
