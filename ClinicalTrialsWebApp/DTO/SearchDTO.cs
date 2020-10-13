using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.DTO
{
    public class SearchDTO
    {
        public string Condition { get; set; }
        public string Country { get; set; }
        public string Sponsor { get; set; }
    }
}
