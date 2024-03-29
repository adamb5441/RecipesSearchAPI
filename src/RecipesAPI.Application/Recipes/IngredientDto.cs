﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesAPI.Application.Recipes
{
    public class IngredientDto
    {
        public string Name { get; set; }

        public double Quantity { get; set; }

        public string Measurement { get; set; }

        public IngredientDto
        (
            string name,
            double quantity,
            string measurement
        )
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Measurement = measurement;
        }
    }
}
