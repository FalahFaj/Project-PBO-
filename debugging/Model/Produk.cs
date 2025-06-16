using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging.Model
{
    public class Produk
    {
        [Key]
        public int id_produk { get; set; }
        public string nama { get; set; }
        public decimal harga { get; set; }
        public int stok { get; set; }
        public string? foto { get; set; }
        [ForeignKey("id_kategori")]
        public int id_kategori { get; set; }
        public bool disewakan { get; set; }
        public Kategori kategori { get; set; }

    }
}
