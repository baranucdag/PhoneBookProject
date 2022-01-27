using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EFCustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var addedEntity = context.Entry(entity);  //get reference
                addedEntity.State = EntityState.Added;    //add entity
                context.SaveChanges();                    //save changes
            }
        }

        public void Delete(Customer entity)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var deletedEntity = context.Entry(entity);  //get reference
                deletedEntity.State = EntityState.Deleted;    //delete entity
                context.SaveChanges();              

            }
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Set<Customer>().SingleOrDefault(filter);
            }
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return filter == null ? context.Set<Customer>().ToList() : context.Set<Customer>().Where(filter).ToList();
                //if filter is null return all info, else return info according to filter
            }
        }

        public void Update(Customer entity)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var updatedEntity = context.Entry(entity);  //get reference
                updatedEntity.State = EntityState.Modified;    //update entity
                context.SaveChanges();                          //save changed
            }
        }
    }
}
