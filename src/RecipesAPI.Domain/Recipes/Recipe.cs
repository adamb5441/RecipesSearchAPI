using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesAPI.Domain.SeedWork;
using RecipesAPI.Domain.Common;

namespace RecipesAPI.Domain.Recipes
{
    public class Recipe : IAggregateRoot
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        public string Directions { get; set; }

        public string Description { get; set; }

        public TimeSpent PrepTime { get; set; }

        public TimeSpent CookTime { get; set; }

        public TimeSpent TotalTime { get; set; }

        public int Yield { get; set; }

        public Guid? User { get; set; }

        public string UserName { get; set; } = "Admin";

        public float Rating { get; set; } = 0;


        public List<Ingredient> Ingredients { get; set; }

        public Recipe
        (
            string name,
            string directions,
            List<Ingredient> ingredients,
            string description,
            int yield
        //TODO: add user when ready
        )
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Directions = directions;
            this.Description = description;
            this.Ingredients = ingredients;
            this.Yield = yield;
        }

    }

}
