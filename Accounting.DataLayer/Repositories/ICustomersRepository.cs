using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModel;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomersRepository
    {
        List<Customers> GetAllCustomers();
        Customers GetCustomerByID(int customerID);

        List<CustomerName_ID> GetCustomerName(string filter = "");
        bool InsertCustomers(Customers customer);
        bool UpdateCustomers(Customers customer);
        bool DeleteCustomers(Customers customer);
        bool DeleteCustomers(int customerID);
        IEnumerable<Customers> GetCustomersByFilter(string key);
        string GetCustomerNameByID(int customerID);
    }
}
