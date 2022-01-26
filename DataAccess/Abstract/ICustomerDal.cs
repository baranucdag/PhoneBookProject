﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstract
{
    public interface ICustomerDal
    {
        List<Customer> GetAll();
        void Add(Customer customer);
        void Update(Customer customer);
    }
}