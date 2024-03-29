﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MediatR;
using System.Threading.Tasks;
using RecipesAPI.Domain.Recipes;

namespace RecipesAPI.Application.Recipes.RemoveRecipe
{
    class RemoveRecipeCommandHandler : IRequestHandler<RemoveRecipeCommand, bool>
    {
        private readonly IRecipeRepository _recipeRepository;

        public RemoveRecipeCommandHandler(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }
        public async Task<bool> Handle(RemoveRecipeCommand command, CancellationToken cancellationToken)
        {
            var recipe = await _recipeRepository.GetRecipeById(command.RecipeId);

            await _recipeRepository.DeleteAsync(recipe);

            return true;
        }
    }
}
