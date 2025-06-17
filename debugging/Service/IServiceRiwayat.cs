using debugging.Model;
using System.Collections.Generic;

namespace debugging.Service
{
    public interface IServiceRiwayat
    {
        List<RiwayatViewModel> GetSemuaRiwayat();
        void UpdateStatusPenyewaan(int idPenyewaan, string status);

    }
}