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
            Customer deneme = new Customer();
            deneme = customerManager.GetByCustomerName("Ahmet Yılmaz");
            Console.WriteLine(deneme.CustomerName);
            /*foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine(customer.CustomerDescription);
            }*/
            Console.WriteLine("aaaa");
        }
    }
}
