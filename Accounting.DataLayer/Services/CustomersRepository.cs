using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using Accounting.ViewModel;

namespace Accounting.DataLayer.Services
{
    public class CustomersRepository : ICustomersRepository
    {
        private Accounting_DBEntities DB;

        public CustomersRepository(Accounting_DBEntities context)
        {
            DB = context;
        }

        public List<Customers> GetAllCustomers()
        {
            return DB.Customers.ToList();
        }

        public Customers GetCustomerByID(int customerID)
        {
            return DB.Customers.Find(customerID);
        }

        public bool InsertCustomers(Customers customer)
        {
            try
            {
                DB.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomers(Customers customer)
        {
            try
            {
                DB.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomers(int customerID)
        {
            try
            {
                Customers customer = DB.Customers.Find(customerID);
                DeleteCustomers(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCustomers(Customers customer)
        {
            try
            {
                /*               var localCatch = DB.Set<Customers>().Local.FirstOrDefault(target => target.CustomerID == customer.CustomerID);
                               if (localCatch != null)
                                   DB.Entry(localCatch).State = EntityState.Detached;*/
                DB.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Customers> GetCustomersByFilter(string key)
        {
            return DB.Customers.Where(customer => customer.FullName.Contains(key) ||
            customer.Email.Contains(key) || customer.PhoneNumber.Contains(key)).ToList();
        }

        public List<CustomerName_ID> GetCustomerName(string filter = "")
        {
            if (filter == "")
                return DB.Customers.Select(customer => new CustomerName_ID
                { FullName = customer.FullName, CustomerID = customer.CustomerID }).ToList();
            return DB.Customers.Where(customer => customer.FullName.Contains(filter)).Select(customer => new CustomerName_ID
            {
                FullName = customer.FullName,
                CustomerID = customer.CustomerID
            }).ToList();
        }

        public string GetCustomerNameByID(int customerID)
        {
            return DB.Customers.Single(customer => customer.CustomerID == customerID).FullName;
        }
    }
}
