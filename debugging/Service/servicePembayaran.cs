using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using debugging.Model;
using debugging.PenghubungDB;
using Project_PBO_Kel_5.Model;

namespace debugging.Service
{
    public class servicePembayaran
    {
        private readonly KoneksiDB _db;

        public servicePembayaran()
        {
            _db = new KoneksiDB();
        }

        public List<Metode_pembayaran> GetAllMetodePembayaran()
        {
            return _db.metode_pembayaran.ToList();
        }
        public Transaksi SimpanTransaksiSatu(Produk produk, int idCustomer, int idMetode, int jumlah)
        {
            var transaksi = new Transaksi
            {
                tanggal = DateTime.UtcNow,
                nominal = produk.harga,
                id_customer = idCustomer,
                id_metode_pembayaran = idMetode,
                id_jenis_transaksi = 1
            };

            _db.transaksi.Add(transaksi);
            _db.SaveChanges();

            var item = new Item_transaksi
            {
                id_produk = produk.id_produk,
                jumlah = jumlah,
                id_transaksi = transaksi.id_transaksi
            };
            _db.produk.FirstOrDefault(p => p.id_produk == produk.id_produk).stok -= jumlah;
            _db.item_transaksi.Add(item);
            _db.SaveChanges();
            return transaksi;
        }
        public Transaksi SimpanTransaksiKeranjang(int idCustomer, int idMetode)
        {
            var keranjang = _db.keranjang.FirstOrDefault(k => k.id_customer == idCustomer);
            if (keranjang == null) return null;

            var detailKeranjang = _db.detail_keranjang
                .Where(dk => dk.id_keranjang == keranjang.id_keranjang).ToList();

            var transaksi = new Transaksi
            {
                tanggal = DateTime.UtcNow,
                nominal = 0,
                id_customer = idCustomer,
                id_metode_pembayaran = idMetode,
                id_jenis_transaksi = 1
            };

            _db.transaksi.Add(transaksi);
            _db.SaveChanges();

            decimal total = 0;

            foreach (var dk in detailKeranjang)
            {
                var produk = _db.produk.FirstOrDefault(p => p.id_produk == dk.id_produk);
                if (produk != null)
                {
                    var item = new Item_transaksi
                    {
                        id_produk = produk.id_produk,
                        jumlah = dk.jumlah,
                        id_transaksi = transaksi.id_transaksi
                    };
                    _db.item_transaksi.Add(item);
                    total += produk.harga * dk.jumlah;
                }
            }
            transaksi.nominal = total;
            _db.detail_keranjang.RemoveRange(detailKeranjang);
            _db.keranjang.Remove(keranjang);
            _db.SaveChanges();

            return transaksi;
        }
    }
}
