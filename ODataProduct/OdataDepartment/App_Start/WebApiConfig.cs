using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using OdataDepartment.Models;

namespace OdataDepartment
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Product>("Products");
            builder.EntitySet<Category>("Categories");
            //builder.EntitySet<Account>("Accounts");
            //builder.EntitySet<PaymentInstrument>("PaymentInstruments");
            config.Routes.MapODataRoute("odata", "odata", builder.GetEdmModel());
        }
    }
}
