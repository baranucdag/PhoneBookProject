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

        [HttpGet()]
        public List<Customer> GetAll([FromQuery] CustomerQueryOption queryOptions)
        {
            var result = _customerService.Get(queryOptions);
            return result;
        }

        [HttpGet("getbyid/{id}")]
        public Customer GetByCustomerId(int id)
        {
            var result = _customerService.getByCustomerId(id);
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
