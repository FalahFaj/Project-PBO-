using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging.Model
{
    public class Keranjang
    {
        [Key]
        public int id_keranjang { get; set; }
        public int id_customer { get; set; }

        public virtual ICollection<Detail_keranjang> detail_keranjang { get; set; }
    }
}
