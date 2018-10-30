using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkDomain.DataModel.Entities
{
    public class rawItemEntity
    {
        public int Id { get; set; }
        public int nr { get; set; }
        public int Artikelid { get; set; }
        public int Varnummer { get; set; }
        public string Namn { get; set; }
        public string Namn2 { get; set; }
        public double Prisinklmoms { get; set; }
        public double Pant { get; set; }
        public double Volymiml { get; set; }
        public double PrisPerLiter { get; set; }
        public DateTime Saljstart { get; set; }
        public bool Utgatt { get; set; }
        public string Varugrupp { get; set; }
        public string Typ { get; set; }
        public string Stil { get; set; }
        public string Forpackning { get; set; }
        public string Forslutning { get; set; }
        public string Ursprung { get; set; }
        public string Ursprunglandnamn { get; set; }
        public string Producent { get; set; }
        public string Leverantor { get; set; }
        public int Argang { get; set; }
        public string Provadargang { get; set; }
        public double Alkoholhalt { get; set; }
        public string Sortiment { get; set; }
        public string SortimentText { get; set; }
        public bool Ekologisk { get; set; }
        public bool Etiskt { get; set; }
        public string EtisktEtikett { get; set; }
        public bool Koscher { get; set; }
        public string RavarorBeskrivning { get; set; }

    }
}
