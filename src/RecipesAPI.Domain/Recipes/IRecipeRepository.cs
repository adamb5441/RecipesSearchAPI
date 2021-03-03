using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesAPI.Domain.Recipes
{
    public interface IRecipeRepository
    {
        Task SaveSingleAsync(Recipe Recipe);

        Task<Recipe> GetRecipeById(Guid id);

        Task DeleteAsync(Recipe Recipe);

        Task SaveBulkAsync(Recipe[] Recipes);
    }
}
