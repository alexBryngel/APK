using ApK.Models;
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
        public DbSet<ItemModel> items { get; set; }
        public DbSet<personModel> persons { get; set; }
    }
}
