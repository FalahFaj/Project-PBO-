using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging.Model
{
    public class Data_chat
    {
        [Key]
        public int id_chat { get; set; }
        public string pesan { get; set; }
        public byte[]? foto { get; set; }
        public int id_customer { get; set; }
        public DateTime waktu_dikirim { get; set; }
        public bool admin { get; set; }
        [ForeignKey("id_customer")]
        public Customer customer { get; set; }
    }
}
