using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CityCoordinates
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string LocationCity { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
    }
}
