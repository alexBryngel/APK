using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkDomain.DataModel.Entities
{
    public class ItemEntity
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public double amount { get; set; }
        public double alcohol { get; set; }
        public double apk { get; set; }

    }
}
