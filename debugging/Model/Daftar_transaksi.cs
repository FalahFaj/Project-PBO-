using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging.Model
{
    public class Daftar_transaksi
    {
        [Key]
        public int id_daftar_transaksi { get; set; }
        public int id_transaksi { get; set; }
        public Daftar_transaksi(){ }
    }
}
