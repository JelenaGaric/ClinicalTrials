using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Pagination
{
    public class PaginationFilter
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public string Condition { get; set; }
        public string Country { get; set; }
        public string Sponsor { get; set; }


        public PaginationFilter()
        {
            this.PageNumber = 1;
            this.PageSize = 10;

        }
        public PaginationFilter(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
            this.PageSize = pageSize > 10 ? 10 : pageSize;
        }

        public PaginationFilter(int pageNumber, int pageSize, string condition, string country, string sponsor)
        {
            this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
            this.PageSize = pageSize > 10 ? 10 : pageSize;
            this.Condition = condition != null ? condition : "";
            this.Country = country != null ? country : "";
            this.Sponsor = sponsor != null ? sponsor : "";

        }
    }
}
