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
    public class ChangeRecipeCommandHandler : IRequestHandler<ChangeRecipeCommand, bool>
    {
        private readonly IRecipeRepository _recipeRepository;

        public ChangeRecipeCommandHandler(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public async Task<bool> Handle(ChangeRecipeCommand command, CancellationToken cancellationToken)
        {
            var recipe = await _recipeRepository.GetRecipeById(command.Id);
            recipe.Name = command.Name;
            recipe.Directions = command.Directions;
            recipe.Ingredients = command
                .Ingredients
                .Select(i => new Ingredient(i.Name, i.Quantity, i.Measurement))
                .ToList();

            await _recipeRepository.SaveSingleAsync(recipe);

            return true;
        }
    }
}
