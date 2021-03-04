using RecipesAPI.Domain.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecipesAPI.Application.Recipes.GetFullRecipe
{
    class GetFullRecipeQueryHandler
    {
        private readonly IRecipeRepository _recipeRepository;

        public GetFullRecipeQueryHandler(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public async Task<RecipeDto> Handle(GetFullRecipeQuery Query, CancellationToken cancellationToken)
        {
            return new RecipeDto();
        }
    }
}
