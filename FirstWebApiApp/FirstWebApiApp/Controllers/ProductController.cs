using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstWebApiApp.Models;

namespace FirstWebApiApp.Controllers
{
    public class ProductController : ApiController
    {

        private ProductContext db = new ProductContext();

        //public List<Product> productList = new List<Product>()
        //{
        //    new Product{Id = 1001,Name = "Product1",Price = 1010,Category = "Cat1"},
        //    new Product{Id = 1002,Name = "Product2",Price = 1020,Category = "Cat2"},
        //    new Product{Id = 1003,Name = "Product3",Price = 1030,Category = "Cat3"},
        //    new Product{Id = 1004,Name = "Product4",Price = 1040,Category = "Cat4"}

        //};

        //public HttpResponseMessage GetAllProduct()
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK, productList);
        //}
        public HttpResponseMessage GetAllProduct()
        {
            return Request.CreateResponse(HttpStatusCode.OK, db.Products);
        }
        // GET: api/Product
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Product/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
