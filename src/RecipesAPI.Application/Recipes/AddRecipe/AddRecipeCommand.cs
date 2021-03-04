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
    public class AddRecipeCommand : CommandBase<Guid>
    {
        public string Name { get; set; }
        public string Directions { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public AddRecipeCommand
        (
            string name,
            string directions,
            List<Ingredient> ingredients
        )
        {
            this.Name = name;
            this.Directions = directions;
            this.Ingredients = ingredients;
        }
    }
}
