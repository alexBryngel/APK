using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkDomain.DataModel.Entities
{
    public class itemEntity
    {
        public int Id { get; set; }
        public int varunummer { get; set; }
        public string name { get; set; }
        public string name2 { get; set; }
        public double price { get; set; }
        public double volymiml { get; set; }
        public double alcohol { get; set; }
        public double apk { get; set; }

        public string varugrupp { get; set; }
        public string typ { get; set; }
        public string ursprungslandnamn { get; set; }            
    }
}
