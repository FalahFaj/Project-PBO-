﻿using System;
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
        void TambahProduk(Produk produk);
        int HitungTotalBarangDisewa();
        int HitungTotalBarangDijual();
        decimal HitungTotalPemasukan();
        int HitungBarangbelumdikembalikan();
        List<Kategori> GetAllKategori();
        List<Produk> ProdukDiSewa(int id_customer);
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
        public List<Produk> ProdukDiSewa(int id_customer)
        {
            var hasil = (from p in db.produk
                        join i in db.item_penyewaan on p.id_produk equals i.id_produk
                        join se in db.penyewaan on i.id_penyewaan equals se.id_penyewaan
                        where se.id_customer == id_customer
                        select p).ToList();
            return hasil;
        }
        public int HitungTotalBarangDisewa()

        {
            var jenisSewa = new List<string> { "dp", "pelunasan" };
            return db.transaksi.Count(t => jenisSewa.Contains(t.jenis_transaksi.nama_jenis.ToLower()));
        }

        public int HitungTotalBarangDijual()

        {
            return db.transaksi.Count(t => t.jenis_transaksi.nama_jenis.ToLower() == "pembelian");
        }
        public decimal HitungTotalPemasukan()
        {
            return db.transaksi.Sum(t => t.nominal);

        }
        public int HitungBarangbelumdikembalikan()
        {
            return db.penyewaan.Count(ip => ip.status_peminjaman.ToLower() == "dipinjam");
        }
    }
}