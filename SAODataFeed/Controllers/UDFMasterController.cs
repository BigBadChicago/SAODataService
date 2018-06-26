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
    public class UDFMasterController : ODataController {
        SAODataFeedContext db = new SAODataFeedContext();
        private bool UDFMasterExists(int key) {
            return db.UDFMaster.Any(udfM => udfM.ID == key);
        }
        protected override void Dispose(bool disposing) {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
