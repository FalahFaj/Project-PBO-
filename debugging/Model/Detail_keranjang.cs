using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging.Model
{
    public class Detail_keranjang
    {
        [Key]
        public int id_detail_keranjang { get; set; }
        public int id_keranjang { get; set; }
        public int id_produk { get; set; }
        public int jumlah { get; set; }
        public virtual Keranjang Keranjang { get; set; }
        public virtual Produk Produk { get; set; }
    }
}
