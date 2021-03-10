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
            var ingredients = command
                .Ingredients
                .Select(i => new Ingredient(i.Name, i.Quantity, i.Measurement))
                .ToList();

            var recipe = new Recipe(command.Name, command.Directions, ingredients, command.Description, command.Yield);

            await _recipeRepository.SaveSingleAsync(recipe);

            return recipe.Id;
        }
    }
}
