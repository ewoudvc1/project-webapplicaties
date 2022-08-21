using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_webapplicaties.Models
{
    public class LidModel
    {
        public int lidID { get; set; }
        public int groepID { get; set; }
        public string  naam { get; set; } 
        public string voornaam { get; set; }
        public string straat { get; set; }
        public string huisnummer { get; set; }
        public int postcode { get; set; }
        public string email { get; set; }
        public string telefoonnummer { get; set; }
    }
}
