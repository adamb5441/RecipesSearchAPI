using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using RecipesAPI.Application.Configuration.Commands;
using RecipesAPI.Domain.Recipes;

namespace RecipesAPI.Application.Recipes
{
    public class RemoveRecipeCommand : CommandBase<bool>
    {
        public RemoveRecipeCommand(Guid recipeId)
        {
            RecipeId = recipeId;
        }

        public Guid RecipeId { get; }
    }
}
