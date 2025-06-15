using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging.Model
{
    public class Item_penyewaan
    {
        [Key]
        public int id_item_penyewaan { get; set; }
        public int id_penyewaan { get; set; }
        public int id_produk { get; set; }
        public int jumlah { get; set; }
        public decimal harga_sewa { get; set; }
        public int durasi_hari { get; set; }
    }
}
