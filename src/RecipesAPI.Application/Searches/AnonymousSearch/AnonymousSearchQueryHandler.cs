using RecipesAPI.Application.Configuration.Queries;
using RecipesAPI.Domain.Recipes.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecipesAPI.Application.Searches.AnonymousSearch
{
    public class AnonymousSearchQueryHandler : IQueryHandler<AnonymousSearchQuery, IEnumerable<SearchResult>>
    {
        private readonly ISearchRepository _searchRepository;

        public AnonymousSearchQueryHandler(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;
        }

        public async Task<IEnumerable<SearchResult>> Handle(AnonymousSearchQuery query, CancellationToken cancellationToken)
        {
            var response = _searchRepository.SearchProductsPage(query.SearchString, query.PageNumber, query.PageSize).Result
                .Select(r => new SearchResult { 
                    Id = r.Id,
                    Description = r.Description,
                    Rating = r.Rating,
                    Name = r.Name,
                });

            return response;
        }
    }
}
