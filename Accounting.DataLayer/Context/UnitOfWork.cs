using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;

namespace Accounting.DataLayer.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {

        Accounting_DBEntities db = new Accounting_DBEntities();

        private ICustomersRepository _customerRepository;

        private IGenericRepository<Accounting> _accountingRepository;

        private IGenericRepository<Login> _loginRepository;

        public ICustomersRepository customersRepository
        {
            get
            {
                if (_customerRepository == null)
                    _customerRepository = new CustomersRepository(db);
                return _customerRepository;
            }
        }

        public IGenericRepository<Accounting> accountingRepository
        {
            get
            {
                if (_accountingRepository == null)
                    _accountingRepository = new GenericRepository<Accounting>(db);
                return _accountingRepository;
            }
        }

        public IGenericRepository<Login> loginRepository
        {
            get
            {
                if (_loginRepository == null)
                    _loginRepository = new GenericRepository<Login>(db);
                return _loginRepository;
            }
        }

        public bool Save()
        {
            db.SaveChanges();
            return true;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
