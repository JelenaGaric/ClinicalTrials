using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Pagination
{
    public class UriService : IUriService
    {
        private readonly string _baseUri;
        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }
        public Uri GetPageUri(PaginationFilter filter, string route)
        {
            var _endpointUri = new Uri(string.Concat(_baseUri, route));
            var modifiedUri = QueryHelpers.AddQueryString(_endpointUri.ToString(), "condition", filter.Condition);
            modifiedUri = QueryHelpers.AddQueryString(modifiedUri, "country", filter.Country);
            modifiedUri = QueryHelpers.AddQueryString(modifiedUri, "sponsor", filter.Sponsor);
            modifiedUri = QueryHelpers.AddQueryString(modifiedUri, "pageNumber", filter.PageNumber.ToString());
            modifiedUri = QueryHelpers.AddQueryString(modifiedUri, "pageSize", filter.PageSize.ToString());
            return new Uri(modifiedUri);
        }
    }
}
