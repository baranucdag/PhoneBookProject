using Business.Concrete;
using DataAccess.Concrete;
using Entities;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
           CustomerManager customerManager = new CustomerManager(new EFCustomerDal());
            foreach (var customer in customerManager.GetIfContains("new"))
            {
                Console.WriteLine(customer.CustomerName);
            }
            var result = customerManager.GetIfContains("new");
            Console.WriteLine(result.Count);
            
        }
    }
}
