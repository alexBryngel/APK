using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkDomain.DataModel.Entities
{
    public class personEntity
    {
        public personEntity()
        {
            items = new List<itemEntity>();
        }
        public int Id { get; set; }
        public string name { get; set; }
        public List<itemEntity> items { get; set; }
    }
}
