using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using debugging.PenghubungDB;
using debugging.AksesLayer;
using debugging.Model;

namespace debugging.Service
{
    public class ServiceProduk
    {
        private readonly IAksesProduk aksesProduk;
        public ServiceProduk(IAksesProduk aksesProduk)
        {
            this.aksesProduk = aksesProduk;
        }
        public List<Produk> GetAllProduk()
        {
            return aksesProduk.GetAllProduk();
        }
        public List<Produk> GetProdukByName(string nama)
        {
            var semuaProduk = GetAllProduk();
            return semuaProduk
                .Where(p => p.nama.ToLower().Contains(nama.ToLower()))
                .ToList();
        }
    }
}
