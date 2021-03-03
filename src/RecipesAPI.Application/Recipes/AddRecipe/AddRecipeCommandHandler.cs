using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RecipesAPI.Domain.Recipes;

namespace RecipesAPI.Application.Recipes
{
    public class AddRecipeCommandHandler : IRequestHandler<AddRecipeCommand, Guid>
    {
        private readonly IRecipeRepository _recipeRepository;

        public AddRecipeCommandHandler(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public async Task<Guid> Handle(AddRecipeCommand command, CancellationToken cancellationToken)
        {
            var recipe = Recipe.CreateRecipe();

            await _recipeRepository.SaveSingleAsync(recipe);

            return recipe.Id;
        }
    }
}
