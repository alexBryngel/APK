using ApK.Models;
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
        public DbSet<ItemEntity> items { get; set; }
        public DbSet<personEntity> persons { get; set; }
    }
}
