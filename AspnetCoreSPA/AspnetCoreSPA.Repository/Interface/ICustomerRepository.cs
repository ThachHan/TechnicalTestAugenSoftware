using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspnetCoreSPA.Data.Entity;
using AspnetCoreSPA.Data.DbManager;
using Microsoft.EntityFrameworkCore;

namespace AspnetCoreSPA.Repository.Interface
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Task<IList<Customer>> GetCustomers();
        Task<IList<Customer>> GetCustomersByName(string name);

    }
}
