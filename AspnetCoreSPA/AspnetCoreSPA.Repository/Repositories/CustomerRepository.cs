using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspnetCoreSPA.Data.Entity;
using AspnetCoreSPA.Data.DbManager;
using Microsoft.EntityFrameworkCore;
using AspnetCoreSPA.Repository.Interface;
using AspnetCoreSPA.Repository;

namespace AspnetCoreSPA.Data.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        #region field and constructor
        private readonly EntityCoreContext _database;
        public CustomerRepository(EntityCoreContext database)
            : base(database)
        {
            _database = database;
        }
        #endregion       

        
        public async Task<IList<Customer>> GetCustomers()
        {
             return await _database.Customer.AsNoTracking().ToListAsync();
        }

        public async Task<IList<Customer>> GetCustomersByName(string name)
        {
            return await _database.Customer.AsNoTracking().Where(n=>n.FirstName.Contains(name) || n.LastName.Contains(name)).ToListAsync();
        }  
    }
}
