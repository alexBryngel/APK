
using ApkDomain.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkDomain.DataModel
{
    public class ApkContext: DbContext
    {
        public ApkContext():base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<ItemEntity> items { get; set; }
        public DbSet<personEntity> persons { get; set; }
        public DbSet<rawItemEntity> rawItems { get; set; }
    }
}
