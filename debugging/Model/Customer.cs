using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging.Model
{
    public class Customer
    {
        [Key]
        public int id_customer { get; set; }
        public string nama { get; set; }
        public string no_hp { get; set; }
        public string email_address { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string? rt { get; set; }
        public string? rw { get; set; }
        public string? kelurahan { get; set; }
        public string? kecamatan { get; set; }
        public string? kota { get; set; }
        public string? provinsi { get; set; }
        public ICollection<Transaksi> transaksi { get; set; }
        public ICollection<Data_chat> data_chat { get; set; }


    }
}
