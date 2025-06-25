using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using debugging.PenghubungDB;
using Project_PBO_Kel_5.Model;
using debugging.Model;

namespace debugging.DAL
{
    public class Akses_customer
    {
        private readonly KoneksiDB _koneksiDB;

        public Akses_customer(KoneksiDB koneksiDB)
        {
            _koneksiDB = koneksiDB;
        }
        public Akun_admin CekLoginAdmin(string username, string password)
        {
            return _koneksiDB.akun_admin.FirstOrDefault(a => a.username == username && a.password == password);
        }
        public Customer cekLogin(string username, string password)
        {
            return _koneksiDB.customer.FirstOrDefault(c => c.username == username && c.password == password);
        }
        public bool UsernameTerdaftar(string username)
        {
            return _koneksiDB.customer.Any(c => c.username == username);
        }
        public bool EmailTerdaftar(string email)
        {
            return _koneksiDB.customer.Any(c => c.email_address == email);
        }
        public void RegisterCustomer(Customer customer)
        {
            _koneksiDB.customer.Add(customer);
            _koneksiDB.SaveChanges();
        }
        public string GetEmail(string email)
        {
            var customer = _koneksiDB.customer.FirstOrDefault(c => c.email_address == email);
            return customer?.email_address ?? string.Empty;
        }
        public bool UpdatePassword(string email, string newPassword)
        {
            var customer = _koneksiDB.customer.FirstOrDefault(c => c.email_address == email);
            if (customer != null)
            {
                customer.password = newPassword;
                _koneksiDB.SaveChanges();
                return true;
            }
            return false;
        }  
    }
}
