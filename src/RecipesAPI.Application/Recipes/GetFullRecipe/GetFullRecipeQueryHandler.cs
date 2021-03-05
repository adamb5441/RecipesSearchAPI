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

        public async Task<RecipeDto> Handle(GetFullRecipeQuery query, CancellationToken cancellationToken)
        {
            var response = await _recipeRepository.GetRecipeById(query.RecipeId);

            var ingredients = response
                .Ingredients
                .Select(i => new IngredientDto(i.Name, i.Quantity, i.Measurement))
                .ToList();

            var recipe = new RecipeDto(response.Id, response.Name, response.Directions, ingredients);

            return recipe;
        }
    }
}
