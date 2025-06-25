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
//         public void HapusProduk(int id)
//         {
//             aksesProduk.HapusProduk(id);
//         }

//         public void UpdateProduk(Produk produk)
//         {
//             aksesProduk.UpdateProduk(produk);
//         }
//         public List<Kategori> GetAllKategori()
//         {
//             return aksesProduk.GetAllKategori();
        public List<Produk> ProdukDiSewa(int id_customer)
        {
            return aksesProduk.ProdukDiSewa(id_customer);
        }
        public List<ProdukDiSewa> GetPenyewaanProdukByCustomer(int idCustomer)
        {
            using (var db = new KoneksiDB())
            {
                var query = from p in db.penyewaan
                            join ip in db.item_penyewaan on p.id_penyewaan equals ip.id_penyewaan
                            join pro in db.produk on ip.id_produk equals pro.id_produk
                            where p.id_customer == idCustomer
                            select new ProdukDiSewa
                            {
                                IdPenyewaan = p.id_penyewaan,
                                TanggalSewa = p.tanggal_sewa,
                                TanggalKembali = p.tanggal_kembali,
                                StatusPeminjaman = p.status_peminjaman,
                                IdCustomer = p.id_customer,
                                IdProduk = ip.id_produk,
                                Jumlah = ip.jumlah,
                                NamaProduk = pro.nama,
                                FotoProduk = pro.foto
                            };
                return query.ToList();
            }
        }
    }
}