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
        Produk GetProdukBById(int id_produk);
        void UpdateProduk(Produk produk);
        void HapusProduk(int id_produk);
        List<Kategori> GetAllKategori();
    }

    public class AksesProduk : IAksesProduk
    {
        private readonly KoneksiDB db;

        public AksesProduk(KoneksiDB db)
        {
            this.db = db;
        }

        public void TambahProduk(Produk produk)
        {
            db.produk.Add(produk);
            db.SaveChanges();
        }

        public Produk GetProdukBById(int id_produk)
        {
            return db.produk.Find(id_produk);
        }

        public void UpdateProduk(Produk produk)
        {
            var existing = db.produk.Find(produk.id_produk);
            if (existing != null)
            {
                db.Entry(existing).CurrentValues.SetValues(produk);
                db.SaveChanges();
            }
        }

        public void HapusProduk(int id_produk)
        {
            var produk = db.produk.Find(id_produk);
            if (produk != null)
            {
                db.produk.Remove(produk);
                db.SaveChanges();
            }
        }

        public List<Produk> GetAllProduk()
        {
            return db.produk.ToList();
        }

        public List<Kategori> GetAllKategori()
        {
            return db.kategori.ToList();
        }
    }
}