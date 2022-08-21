using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_webapplicaties.Models
{
    public class EvenementModel
    {
        public int EvenementID { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public DateTime Datum {get; set;}
    }
}
