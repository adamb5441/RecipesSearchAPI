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
    public class ChangeRecipeCommand : CommandBase<bool>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Directions { get; set; }
        public List<IngredientDto> Ingredients { get; set; }

        public ChangeRecipeCommand
        (
            Guid id,
            string name,
            string directions,
            List<IngredientDto> ingredients
        )
        {
            this.Id = id;
            this.Name = name;
            this.Directions = directions;
            this.Ingredients = ingredients;
        }
    }
}
