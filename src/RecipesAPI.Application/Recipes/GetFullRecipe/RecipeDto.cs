using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesAPI.Application.Recipes
{
    public class RecipeDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Directions { get; set; }

        public List<IngredientDto> Ingredients { get; set; }

        public RecipeDto
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
