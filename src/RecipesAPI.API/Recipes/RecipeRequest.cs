﻿using RecipesAPI.Application.Recipes;
using RecipesAPI.Domain.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.API.Recipes
{
    public class RecipeRequest
    {
        public string Name { get; set; }

        public string Directions { get; set; }

        public string Description { get; set; }

        public int Yield { get; set; }

        public List<IngredientDto> Ingredients { get; set; }
    }
}
