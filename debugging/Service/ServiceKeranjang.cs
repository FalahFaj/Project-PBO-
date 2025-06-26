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
    public class BaseService
    {
        protected KoneksiDB CreateDbContext() => new KoneksiDB();
        protected bool ExecuteWithCatch(Action<KoneksiDB> action, out string error)
        {
            error = null;
            try
            {
                using (var db = CreateDbContext())
                {
                    action(db);
                }
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
    public class ServiceKeranjang : BaseService
    {
        public bool TambahKeranjang(int idCustomer, int idProduk, int jumlah, out string error)
        {
            return ExecuteWithCatch(db =>
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
            }, out error);
        }
    }
}
