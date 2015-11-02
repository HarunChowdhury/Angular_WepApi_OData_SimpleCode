using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstWebApiApp.Models;

namespace FirstWebApiApp.Controllers
{
    public class CategoryController : ApiController
    {
           
        private ProductContext db=new ProductContext();

        //public List<Category> categoryList = new List<Category>()
        //{
        //    new Category{Id = 101,Name = "Cat1",Description = "Descrip01"},
        //    new Category{Id = 102,Name = "Cat2",Description = "Descrip02"},
        //    new Category{Id = 103,Name = "Cat3",Description = "Descrip03"},
        //    new Category{Id = 104,Name = "Cat4",Description = "Descrip04"}
        //};

        //public HttpResponseMessage GetAllCategory()
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK, categoryList);
        //}

        public HttpResponseMessage GetAllCategory()
        {
            return Request.CreateResponse(HttpStatusCode.OK, db.Categorys);
        }

        // GET: api/Category
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Category/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        
        // POST: api/Category
        public HttpResponseMessage Post(Category category)
        {
            db.Categorys.Add(category);
            var response = Request.CreateResponse(HttpStatusCode.Created, category);
            string uri = Url.Link("DefaultApi", new { id = category.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
        }
    }
}
