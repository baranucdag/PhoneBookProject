using Core.Abstract;
using DataAccess.Concrete;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete
{
    public class EFCustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var addedEntity = context.Entry(entity);  //get reference
                addedEntity.State = EntityState.Added;    //add entity
                context.SaveChanges();                    //sace changed
            }
        }

        public void Delete(Customer entity)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var deletedEntity = context.Entry(entity);  //get reference
                deletedEntity.State = EntityState.Deleted;    //delete entity

            }
        }

        public List<Customer> GetAll()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Set<Customer>().ToList();    /* we dont have any filter, if we had filter we would
                                                            use context.Set<Customer>().ToList().where(filter).ToList() */

            }
        }

        public void Update(Customer entity)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var updatedEntity = context.Entry(entity);  //get reference
                updatedEntity.State = EntityState.Modified;    //add entity

            }
        }
    }
}
