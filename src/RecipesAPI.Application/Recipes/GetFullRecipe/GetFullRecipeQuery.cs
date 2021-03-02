using RecipesAPI.Application.Configuration.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesAPI.Application.Recipes.GetFullRecipe
{
    public class GetFullRecipeQuery : IQuery<RecipeDto>
    {
        public GetFullRecipeQuery(Guid recipeId)
        {
            RecipeId = recipeId;
        }

        public Guid RecipeId { get; }
    }
}
