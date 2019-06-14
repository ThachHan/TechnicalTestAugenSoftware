using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetCoreSPA.Data.Entity;
using AspnetCoreSPA.Repository.Interface;
using AspnetCoreSPA.Service.Interface;

namespace DotNetCore.Service
{
    public class CustomerService : ICustomerService
    {
        #region Field and constructor
        private readonly ICustomerRepository _customerRepository;

        #endregion
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        
        public async Task<IList<Customer>> GetCustomers()
        {
            return await _customerRepository.GetCustomers();
        }

        public async Task<IList<Customer>> GetCustomersByName(string name)
        {
            return await _customerRepository.GetCustomersByName(name);
        }
    }
}
