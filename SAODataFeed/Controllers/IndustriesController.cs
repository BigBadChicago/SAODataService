using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;
using SAODataFeed.Models;

namespace SAODataFeed.Controllers
{
    public class IndustriesController : ODataController {
        SAODataFeedContext db = new SAODataFeedContext();
        private bool IndustryExists(int key) {
            return db.Industries.Any(ind => ind.ID == key);
        }
        protected override void Dispose(bool disposing) {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}

