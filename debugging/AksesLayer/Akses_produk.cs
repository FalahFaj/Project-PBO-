using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using debugging.Model;
using debugging.PenghubungDB;

namespace debugging.AksesLayer
{
    public interface IAksesProduk
    {
        List<Produk> GetAllProduk();
    }
    public class AksesProduk : IAksesProduk
    {
        private readonly KoneksiDB _koneksiDB;
        public AksesProduk(KoneksiDB koneksiDB)
        {
            _koneksiDB = koneksiDB;
        }
        public List<Produk> GetAllProduk()
        {
            return _koneksiDB.produk.ToList();
        }
    }
}
