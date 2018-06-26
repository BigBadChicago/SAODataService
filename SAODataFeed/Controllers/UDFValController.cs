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
    public class UDFValController : ODataController {
        SAODataFeedContext db = new SAODataFeedContext();
        private bool UDFValExists(int key) {
            return db.UDFVal.Any(udfV => udfV.UID == key);
        }
        protected override void Dispose(bool disposing) {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}