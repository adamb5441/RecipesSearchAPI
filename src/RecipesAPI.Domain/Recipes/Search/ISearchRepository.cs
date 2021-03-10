using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesAPI.Domain.Recipes.Search
{
    public interface ISearchRepository
    {
        Task<Recipe[]> SearchProductsPage(string query, int page, int pageSize);
    }
}
