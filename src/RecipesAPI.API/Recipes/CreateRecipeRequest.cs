using RecipesAPI.Application.Recipes;
using RecipesAPI.Domain.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.API.Recipes
{
    public class CreateRecipeRequest
    {
        public string Name { get; set; }

        public string Directions { get; set; }

        public List<Ingredient> Ingredients { get; set; }
    }
}
