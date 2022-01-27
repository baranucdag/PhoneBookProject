using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=KJ4FUIB1;Database=PhoneBook;Trusted_Connection=true"); 
           /*(@"Server=KJFUIB1\90544;Database=PhoneBook;Trusted_Connection=true");*/
        }
        public DbSet<Customer> Customers { get; set; } 

    }
}
