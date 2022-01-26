using Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime CustomerBirthDate { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerDescription { get; set; }
    }
}
