using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using debugging.Model;
using debugging.AksesLayer;
using debugging.PenghubungDB;

namespace debugging.Service
{
    public class ServiceKeranjang
    {
        public static bool TambahKeranjang(int idCustomer, int idProduk, int jumlah, out string error)
        {
            error = null;
            try
            {
                using (var db = new KoneksiDB())
                {
                    var keranjang = db.keranjang.FirstOrDefault(k => k.id_customer == idCustomer);
                    if (keranjang == null)
                    {
                        keranjang = new Keranjang { id_customer = idCustomer };
                        db.keranjang.Add(keranjang);
                        db.SaveChanges();
                    }
                    var detailKeranjang = db.detail_keranjang
                        .FirstOrDefault(dk => dk.id_keranjang == keranjang.id_keranjang && dk.id_produk == idProduk);
                    if (detailKeranjang == null)
                    {
                        detailKeranjang = new Detail_keranjang
                        {
                            id_keranjang = keranjang.id_keranjang,
                            id_produk = idProduk,
                            jumlah = jumlah
                        };
                        db.produk.FirstOrDefault(p => p.id_produk == idProduk).stok -= jumlah;
                        db.detail_keranjang.Add(detailKeranjang);
                    }
                    else
                    {
                        detailKeranjang.jumlah += jumlah;
                    }
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                error = $"Gagal menambahkan ke keranjang: {ex.Message}";
                return false;
            }

        }
    }
}
