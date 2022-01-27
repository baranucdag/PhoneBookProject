using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getall")]
        public List<Customer> GetAll()
        {
            var result = _customerService.GetAll();
            return result;
        }

        [HttpGet("getbycustomername")]
        public Customer GetByCustomerName(string customerName)
        {
            var result = _customerService.GetByCustomerName(customerName);
            return result; 
        }

        [HttpGet("getbycustomerphonenumber")]
        public Customer GetBtCustomerPhoneNumber(string customerPhoneNumber)
        {
            var result = _customerService.GetByPhoneNumber(customerPhoneNumber);
            return result;
        }

        [HttpPost("add")]
        public void Add(Customer customer)
        {
            _customerService.Add(customer); 
        }

        [HttpPost("update")]
        public void Update(Customer customer)
        {
            _customerService.Update(customer);
        }

        [HttpPost("delete")]
        public void Delete(Customer customer)
        {
            _customerService.Delete(customer);
        }


    }
}
