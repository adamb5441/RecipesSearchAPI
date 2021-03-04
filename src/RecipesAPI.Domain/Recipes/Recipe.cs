using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesAPI.Domain.SeedWork;

namespace RecipesAPI.Domain.Recipes
{
    public class Recipe : IAggregateRoot
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        public string Directions { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public Recipe
        (
            string name,
            string directions,
            List<Ingredient> ingredients
)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Directions = directions;
            this.Ingredients = ingredients;
        }
    }
}
