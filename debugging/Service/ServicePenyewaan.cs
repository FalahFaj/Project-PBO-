using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using debugging.Model;
using debugging.AksesLayer;
using debugging.PenghubungDB;
using Project_PBO_Kel_5.Model;

namespace debugging.Service
{
    public class PenyewaanService
    {
        private readonly UserLogin _userLogin;
        private readonly Produk _produk;

        public PenyewaanService(UserLogin userLogin, Produk produk)
        {
            _userLogin = userLogin;
            _produk = produk;
        }
        public Customer GetCustomerData()
        {
            using var db = new KoneksiDB();
            return db.customer.FirstOrDefault(c => c.id_customer == _userLogin.Id);
        }
        public List<Metode_pembayaran> GetMetodePembayaran()
        {
            using var db = new KoneksiDB();
            return db.metode_pembayaran.ToList();
        }
        public bool ValidateAlamat(Customer customer)
        {
            return !(string.IsNullOrEmpty(customer.rt) &&
                     string.IsNullOrEmpty(customer.rw) &&
                     string.IsNullOrEmpty(customer.kelurahan) &&
                     string.IsNullOrEmpty(customer.kecamatan) &&
                     string.IsNullOrEmpty(customer.kota));
        }
        public decimal HitungTotalSewa(int jumlah)
        {
            decimal dp = _produk.harga / 2;
            return dp * jumlah;
        }
        public void SimpanPenyewaan(
            DateTime tanggalSewa,
            DateTime tanggalKembali,
            int jumlah,
            string metodePembayaran,
            out string errorMessage)
        {
            errorMessage = null;
            try
            {
                using var db = new KoneksiDB();

                var penyewaan = new Penyewaan
                {
                    tanggal_sewa = DateTime.SpecifyKind(tanggalSewa, DateTimeKind.Utc),
                    tanggal_kembali = DateTime.SpecifyKind(tanggalKembali, DateTimeKind.Utc),
                    pembayaran_dp = HitungTotalSewa(jumlah),
                    status_dp = "Belum Dibayar",
                    status_peminjaman = "Menunggu Konfirmasi",
                    id_customer = _userLogin.Id
                };
                db.penyewaan.Add(penyewaan);
                db.SaveChanges();

                var item_penyewaan = new Item_penyewaan
                {
                    id_penyewaan = penyewaan.id_penyewaan,
                    id_produk = _produk.id_produk,
                    jumlah = jumlah,
                    harga_sewa = HitungTotalSewa(jumlah),
                    durasi_hari = (tanggalKembali - tanggalSewa).Days
                };
                db.item_penyewaan.Add(item_penyewaan);
                db.produk.FirstOrDefault(p => p.id_produk == _produk.id_produk).stok -= jumlah;
                db.SaveChanges();

                var metode = db.metode_pembayaran.FirstOrDefault(m => m.metode_pembayaran == metodePembayaran);
                if (metode == null) throw new Exception("Metode pembayaran tidak ditemukan.");

                var transaksi = new Transaksi
                {
                    tanggal = DateTime.UtcNow,
                    nominal = HitungTotalSewa(jumlah) / 2,
                    id_customer = _userLogin.Id,
                    id_metode_pembayaran = metode.id_metode_pembayaran,
                    id_penyewaan = penyewaan.id_penyewaan,
                    id_jenis_transaksi = 2
                };
                db.transaksi.Add(transaksi);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                errorMessage = $"Terjadi kesalahan saat menyimpan data: {ex.Message}";
                if (ex.InnerException != null)
                    errorMessage += $"\nDetail: {ex.InnerException.Message}";
            }
        }
    }
}
