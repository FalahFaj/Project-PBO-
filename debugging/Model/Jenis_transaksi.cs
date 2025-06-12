using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging.Model
{
    public class Jenis_transaksi
    {
        [Key]
        public int id_jenis_transaksi { get; set; }
        public string nama_jenis { get; set; }
        public ICollection<Transaksi> transaksi { get; set; }
    }
}
