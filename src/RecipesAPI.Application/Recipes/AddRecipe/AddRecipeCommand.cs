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

        public string Description { get; set; }

        public int Yield { get; set; }

        public List<IngredientDto> Ingredients { get; set; }

        public AddRecipeCommand
        (
            string name,
            string directions,
            List<IngredientDto> ingredients,
            string description,
            int yield
        )
        {
            this.Name = name;
            this.Directions = directions;
            this.Description = description;
            this.Ingredients = ingredients;
            this.Yield = yield;
        }
    }
}
