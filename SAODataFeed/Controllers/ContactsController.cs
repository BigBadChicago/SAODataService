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
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using SalesAssistODataFeed.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<TblContact>("Contacts");
    builder.EntitySet<TblMerchant>("TblMerchants"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class ContactsController : ODataController
    {
        private SAODataFeedContext db = new SAODataFeedContext();

        // GET: odata/Contacts
        [EnableQuery]
        public IQueryable<TblContact> GetContacts()
        {
            return db.Contacts;
        }

        // GET: odata/Contacts(5)
        [EnableQuery]
        public SingleResult<TblContact> GetTblContact([FromODataUri] int key)
        {
            return SingleResult.Create(db.Contacts.Where(tblContact => tblContact.ID == key));
        }

        // PUT: odata/Contacts(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<TblContact> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TblContact tblContact = db.Contacts.Find(key);
            if (tblContact == null)
            {
                return NotFound();
            }

            patch.Put(tblContact);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblContactExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(tblContact);
        }

        // POST: odata/Contacts
        public IHttpActionResult Post(TblContact tblContact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Contacts.Add(tblContact);
            db.SaveChanges();

            return Created(tblContact);
        }

        // PATCH: odata/Contacts(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<TblContact> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TblContact tblContact = db.Contacts.Find(key);
            if (tblContact == null)
            {
                return NotFound();
            }

            patch.Patch(tblContact);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblContactExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(tblContact);
        }

        // DELETE: odata/Contacts(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            TblContact tblContact = db.Contacts.Find(key);
            if (tblContact == null)
            {
                return NotFound();
            }

            db.Contacts.Remove(tblContact);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Contacts(5)/TblMerchant
        [EnableQuery]
        public SingleResult<TblMerchant> GetTblMerchant([FromODataUri] int key)
        {
            return SingleResult.Create(db.Contacts.Where(m => m.ID == key).Select(m => m.TblMerchant));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TblContactExists(int key)
        {
            return db.Contacts.Count(e => e.ID == key) > 0;
        }
    }
}
