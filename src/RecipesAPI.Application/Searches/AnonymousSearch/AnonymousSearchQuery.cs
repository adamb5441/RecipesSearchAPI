using RecipesAPI.Application.Configuration.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesAPI.Application.Searches.AnonymousSearch
{
    public class AnonymousSearchQuery : IQuery<IEnumerable<SearchResult>>
    {
        public AnonymousSearchQuery(string searchString, int pageNumber, int pageSize)
        {
            SearchString = searchString;
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

        public string SearchString { get; }
        public int PageNumber { get; }
        public int PageSize { get; }
    }
}
