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
    public class UserAccessController : ODataController {
        SAODataFeedContext db = new SAODataFeedContext();
        private bool UserAccessExists(string key) {
            return db.UserAccess.Any(UA => UA.UserID == key);
        }
        protected override void Dispose(bool disposing) {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
