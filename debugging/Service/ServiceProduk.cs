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
        private readonly debugging.AksesLayer.IAksesProduk aksesProduk;

        public ServiceProduk(debugging.AksesLayer.IAksesProduk aksesProduk)
        {
            this.aksesProduk = aksesProduk;
        }

        public List<Produk> GetAllProduk()
        {
            return aksesProduk.GetAllProduk();
        }

        public List<Produk> GetProdukByName(string nama)
        {
            return aksesProduk.GetAllProduk().Where(p => p.nama.Contains(nama)).ToList();
        }

        public Produk GetProdukBById(int id_produk)
        {
            return aksesProduk.GetProdukBById(id_produk);
        }

        public void TambahProduk(Produk produk)
        {
            aksesProduk.UpdateProduk(produk);
        }
        public void HapusProduk(int id)
        {
            aksesProduk.HapusProduk(id);
        }

        public void UpdateProduk(Produk produk)
        {
            aksesProduk.UpdateProduk(produk);
        }
        public List<Kategori> GetAllKategori()
        {
            return aksesProduk.GetAllKategori();
        }
    }
}