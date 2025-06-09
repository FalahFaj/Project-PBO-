using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using debugging.DAL;
using debugging.Model;

namespace debugging.Service
{
    public class ServiceAkun
    {
        private readonly Akses_customer aksesCustomer;
        public ServiceAkun(Akses_customer akses_Customer)
        {
            aksesCustomer = akses_Customer;
        }
        public UserLogin Login(string username, string password)
        {
            var admin = aksesCustomer.CekLoginAdmin(username, password);
            if (admin != null)
            {
                return new UserLogin
                {
                    Id = admin.id_admin,
                    Name = admin.nama,
                    Username = admin.username,
                    Role = "Admin"
                };
            }
            var customer = aksesCustomer.cekLogin(username, password);
            if (customer != null)
            {
                return new UserLogin
                {
                    Id = customer.id_customer,
                    Name = customer.nama,
                    Username = customer.username,
                    Role = "Customer"
                };
            }
            return null;
        }
        public bool Register(Customer customer)
        {
            if (aksesCustomer.UsernameTerdaftar(customer.username))
                return false;
            if (aksesCustomer.EmailTerdaftar(customer.email_address))
                return false;

            aksesCustomer.RegisterCustomer(customer);
            return true;
        }
    }
}
