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
    public abstract class PembyaranStrategi
    {
        protected readonly KoneksiDB _db = new();
        public abstract Transaksi SimpanTransaksi(int idCustomer, int idMetode);
    }
    public class PembayaranSatuan : PembyaranStrategi
    {
        private readonly Produk _produk;
        private readonly int _jumlah;
        public PembayaranSatuan(Produk produk, int jumlah)
        {
            _produk = produk;
            _jumlah = jumlah;
        }
        public override Transaksi SimpanTransaksi(int idCustomer, int idMetode)
        {
            var transaksi = new Transaksi
            {
                tanggal = DateTime.UtcNow,
                nominal = _produk.harga * _jumlah,
                id_customer = idCustomer,
                id_metode_pembayaran = idMetode,
                id_jenis_transaksi = 1
            };
            _db.transaksi.Add(transaksi);
            _db.SaveChanges();

            var item = new Item_transaksi
            {
                id_produk = _produk.id_produk,
                jumlah = _jumlah,
                id_transaksi = transaksi.id_transaksi
            };
            _db.produk.FirstOrDefault(p => p.id_produk == _produk.id_produk).stok -= _jumlah;
            _db.item_transaksi.Add(item);
            _db.SaveChanges();

            return transaksi;
        }
    }
    public class PembayaranKeranjang : PembyaranStrategi
    {
        private readonly List<(int id_produk, int jumlah)> _produkDipilih;
        public PembayaranKeranjang(List<(int id_produk, int jumlah)> produkDipilih)
        {
            _produkDipilih = produkDipilih;
        }

        public override Transaksi SimpanTransaksi(int idCustomer, int idMetode)
        {

            if (_produkDipilih == null || _produkDipilih.Count == 0) return null;

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
            foreach (var (id_produk, jumlah) in _produkDipilih)
            {
                var produk = _db.produk.FirstOrDefault(p => p.id_produk == id_produk);
                if (produk != null)
                {
                    var item = new Item_transaksi
                    {
                        id_produk = produk.id_produk,
                        jumlah = jumlah,
                        id_transaksi = transaksi.id_transaksi
                    };
                    _db.item_transaksi.Add(item);
                    total += produk.harga * jumlah;

                    var detail = _db.detail_keranjang.FirstOrDefault(dk => dk.id_produk == id_produk && dk.Keranjang.id_customer == idCustomer);
                    if (detail != null)
                        _db.detail_keranjang.Remove(detail);
                }
            }
            transaksi.nominal = total;
            _db.SaveChanges();

            var keranjang = _db.keranjang.FirstOrDefault(k => k.id_customer == idCustomer);
            if (keranjang != null && !_db.detail_keranjang.Any(dk => dk.id_keranjang == keranjang.id_keranjang))
            {
                _db.keranjang.Remove(keranjang);
                _db.SaveChanges();
            }
            return transaksi;
        }
    }
    public class servicePembayaran
    {
        public List<Metode_pembayaran> GetAllMetodePembayaran()
        {
            using var db = new KoneksiDB();
            return db.metode_pembayaran.ToList();
        }
        public Transaksi SimpanTransaksi(PembyaranStrategi strategi, int idCustomer, int idMetode)
        {
            return strategi.SimpanTransaksi(idCustomer, idMetode);
        }
    }
}
