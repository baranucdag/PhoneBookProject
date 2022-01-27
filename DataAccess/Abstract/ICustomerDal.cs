using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICustomerDal
    {
        List<Customer> GetAll(Expression<Func<Customer, bool>> filter=null);
        Customer Get(Expression<Func<Customer,bool>> filter);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
