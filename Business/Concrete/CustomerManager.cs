using Entities;
using Business.Abstract;
using DataAccess.Abstract;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public List<Customer> Get(CustomerQueryOption queryOption)
        {
            if (string.IsNullOrEmpty(queryOption.Search)) return _customerDal.GetAll();
            return _customerDal.GetAll(x => x.CustomerPhoneNumber.Contains(queryOption.Search) || x.CustomerName.Contains(queryOption.Search));
        }

        public Customer getByCustomerId(int id)
        {
            return _customerDal.Get(p=>p.Id==id);
        }

        public List<Customer> GetIfContains(string input)
        {
            return _customerDal.GetAll(p => p.CustomerName.Contains(input) || p.CustomerPhoneNumber.Contains(input));
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }
    }

    public class CustomerQueryOption
    {
        public string Search { get; set; }
    }
}
