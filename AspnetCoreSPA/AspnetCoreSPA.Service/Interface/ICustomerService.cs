using AspnetCoreSPA.Data.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspnetCoreSPA.Service.Interface
{
    public interface ICustomerService
    {
        Task<IList<Customer>> GetCustomers();
        Task<IList<Customer>> GetCustomersByName(string name);
    }
}
