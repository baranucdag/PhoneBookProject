using Entities;
using Business.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> Get(CustomerQueryOption queryOption);
        public List<Customer> GetIfContains(string input);
        Customer getByCustomerId(int id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
