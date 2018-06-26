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
    public class StatusController : ODataController {
        SAODataFeedContext db = new SAODataFeedContext();
        private bool StatusExists(int key) {
            return db.Status.Any(status => status.ID == key);
        }
        protected override void Dispose(bool disposing) {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
