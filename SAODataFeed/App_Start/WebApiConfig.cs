using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.Data.Edm;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;
using SAODataFeed.Models;


namespace SAODataFeed
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services


            // Web API routes

            config.Routes.MapODataServiceRoute("odata", "odata", GetImplicitEDM());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static IEdmModel GetImplicitEDM() {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<TblBusinessType>("BusinessTypes");
            builder.EntitySet<TblContact>("Contacts");
            builder.EntitySet<TblIndustry>("Industries");
            builder.EntitySet<TblMerchant>("Merchants");
            builder.EntitySet<TblStatus>("Status");
            builder.EntitySet<TblUdfMaster>("UDFMaster");
            builder.EntitySet<TblUdfVal>("UDFVal");
            builder.EntitySet<TblUserAccess>("UserAccess");
            return builder.GetEdmModel();
        }

    }
}
