using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging.Model
{
    public class Kategori
    {
        [Key]
        public int id_kategori { get; set; }
        public string nama_kategori { get; set; }
        public ICollection<Produk> produk { get; set; }
        public Kategori(int id_kategori, string nama_kategori)
        {
            this.id_kategori = id_kategori;
            this.nama_kategori = nama_kategori;
        }
    }
}
