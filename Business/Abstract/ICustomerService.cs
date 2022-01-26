﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
