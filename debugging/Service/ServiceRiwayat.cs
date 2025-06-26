using debugging.Model;
using debugging.PenghubungDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace debugging.Service
{
    public class ServiceRiwayat : IServiceRiwayat
    {
        private readonly KoneksiDB db;
        public ServiceRiwayat(KoneksiDB dbContext)
        {
            this.db = dbContext;
        }
        public List<RiwayatViewModel> GetSemuaRiwayat()
        {
            var riwayatSewa = (from p in db.penyewaan
                               join c in db.customer on p.id_customer equals c.id_customer
                               join d in db.item_penyewaan on p.id_penyewaan equals d.id_penyewaan
                               join pr in db.produk on d.id_produk equals pr.id_produk
                               select new RiwayatViewModel
                               {
                                   Tipe = "Sewa",
                                   IdTransaksi = p.id_penyewaan,
                                   NamaPelanggan = c.nama,
                                   Tanggal = p.tanggal_sewa,
                                   KeteranganProduk = pr.nama,
                                   Status = p.status_peminjaman,
                                   Total = d.jumlah * pr.harga
                               }).ToList();

            var riwayatBeli = (from t in db.transaksi
                               join c in db.customer on t.id_customer equals c.id_customer
                               where t.id_jenis_transaksi == 2
                               select new RiwayatViewModel
                               {
                                   Tipe = "Beli",
                                   IdTransaksi = t.id_transaksi,
                                   NamaPelanggan = c.nama,
                                   Tanggal = t.tanggal,
                                   KeteranganProduk = "Pembelian Produk",
                                   Status = t.nominal.ToString(),
                                   Total = t.nominal 
                               }).ToList();
            return riwayatSewa.Concat(riwayatBeli).ToList();
        }
        public void UpdateStatusPenyewaan(int idPenyewaan, string status)
        {
            var transaksi = db.penyewaan.Find(idPenyewaan);
            if (transaksi != null)
            {
                transaksi.status_peminjaman = status;
                db.SaveChanges();
            }
            else
            {
                throw new Exception($"Transaksi penyewaan dengan ID {idPenyewaan} tidak ditemukan.");
            }
        }
    }
}