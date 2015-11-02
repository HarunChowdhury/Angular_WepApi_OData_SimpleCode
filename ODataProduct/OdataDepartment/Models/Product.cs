using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdataDepartment.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Quality { get; set; }
        public virtual  Category Categorys{ get; set; } 
    }
}