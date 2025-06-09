using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging.Model
{
    public class Akun_admin
    {
        [Key]
        public int id_admin { get; set; }
        public string nama { get; set; }
        public string no_hp { get; set; }
        public string username { get; set; }
        public string password { get; set; }

    }
}
