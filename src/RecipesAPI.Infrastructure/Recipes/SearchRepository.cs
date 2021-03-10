using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using RecipesAPI.Domain.Recipes;
using RecipesAPI.Domain.Recipes.Search;

namespace RecipesAPI.Infrastructure.Recipes
{
    public class SearchRepository : ISearchRepository
    {
        private readonly IElasticClient _elasticClient;

        public SearchRepository(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }
        public async Task<Recipe[]> SearchProductsPage(string query, int page, int pageSize)
        {
            var response = await _elasticClient.SearchAsync<Recipe>(s =>
            s.Query(q => q.QueryString(d => d.Query('*' + query + '*')))
            .From((page - 1) * pageSize)
            .Size(pageSize));
            if (!response.IsValid)
            {
                return new Recipe[] { };
            }

            return response.Documents.ToArray();
        }
    }
}
