using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging.Model
{
    public class Item_transaksi
    {
        [Key]
        public int id_item_transaksi { get; set; }
        public int id_produk { get; set; }
        public int jumlah { get; set; }
        [ForeignKey("id_transaksi")]
        public int id_transaksi { get; set; }
    }
}
