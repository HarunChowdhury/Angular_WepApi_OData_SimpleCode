using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WepApiWithAngularCREU.Models
{
    public class CustomerContext:DbContext
    {
        public CustomerContext()
            : base("name=CustomerContext")
        {
            
        }

        public DbSet<Customer> Customers { get; set; }

        internal object GetCustomers()
        {
            throw new NotImplementedException();
        }
    }
}