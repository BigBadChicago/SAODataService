using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SAODataFeed.Models
{
    public class SAODataFeedContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SAODataFeedContext() : base("name=SAODataFeedContext")
        {
        }

        public DbSet<TblContact> Contacts { get; set; }
        public DbSet<TblBusinessType> BusinessTypes { get; set; }
        public DbSet<TblIndustry> Industries { get; set; }
        public DbSet<TblMerchant> Merchants { get; set; }
        public DbSet<TblStatus> Status { get; set; }
        public DbSet<TblUdfMaster> UDFMaster { get; set; }
        public DbSet<TblUdfVal> UDFVal { get; set; }
        public DbSet<TblUserAccess> UserAccess { get; set; }

    }
}
