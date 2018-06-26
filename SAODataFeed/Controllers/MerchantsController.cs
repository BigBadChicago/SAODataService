using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using SAODataFeed.Models;

namespace SAODataFeed.Controllers
{
    public class MerchantsController : ODataController
    {
        SAODataFeedContext db = new SAODataFeedContext();
        private bool MerchantExists(int key) {
            return db.Merchants.Any(m => m.ID == key);
        }
        protected override void Dispose(bool disposing) {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
