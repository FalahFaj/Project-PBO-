using debugging.AksesLayer;
using debugging.DAL;
using debugging.Model;
using debugging.PenghubungDB;
using debugging.Service;
using debugging;
using System.Windows.Forms;
using System; // Pastikan ini juga ada

[STAThread]
static void Main()
{
    try
    {
        ApplicationConfiguration.Initialize();

        KoneksiDB db = new KoneksiDB(); // Pastikan tidak ada error di konstruktor ini lagi
        Akses_customer aksesCustomer = new Akses_customer(db);
        IAksesProduk aksesProduk = new AksesProduk(db);
        ServiceAkun serviceAkun = new ServiceAkun(aksesCustomer); // serviceAkun ini dibuat di sini
        ServiceProduk serviceProduk = new ServiceProduk(aksesProduk);
        IServiceRiwayat serviceRiwayat = new ServiceRiwayat(db);
        MessageBox.Show("Mencoba menampilkan form Login...", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        using (Login loginForm = new Login(serviceAkun)) // <-- DAN serviceAkun ini DITERUSKAN DI SINI
        {
            MessageBox.Show("Login form berhasil dibuat. Mencoba ShowDialog()...", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Login berhasil! Role: " + loginForm.LoggedInUser.Role, "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UserLogin loggedInUser = loginForm.LoggedInUser;
                if (loggedInUser.Role == "Admin")
                {
                    Application.Run(new dashboard_admin2(
                        serviceAkun,
                        serviceProduk,
                        aksesProduk,
                        serviceRiwayat,
                        loggedInUser
                    ));
                }
                else if (loggedInUser.Role == "Customer")
                {
                    Application.Run(new DashboardUser(serviceAkun, loggedInUser));
                }
            }
            else
            {
                MessageBox.Show("Login dibatalkan atau gagal. Aplikasi akan keluar.", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Aplikasi mengalami kesalahan fatal: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}