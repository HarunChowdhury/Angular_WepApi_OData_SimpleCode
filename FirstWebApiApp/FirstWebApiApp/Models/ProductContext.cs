using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstWebApiApp.Models
{
    public class ProductContext:DbContext
    {
        public ProductContext()
            : base("name=ProductContext")
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; } 
    }
}