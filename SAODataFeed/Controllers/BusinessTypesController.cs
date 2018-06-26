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
    public class BusinessTypesController : ODataController {
        SAODataFeedContext db = new SAODataFeedContext();
        private bool BusinessTypeExists(int key) {
            return db.BusinessTypes.Any(bt => bt.ID == key);
        }
        protected override void Dispose(bool disposing) {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
