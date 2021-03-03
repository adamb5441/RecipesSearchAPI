﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipesAPI.Application.Recipes;

namespace RecipesAPI.API.Recipes
{
    public class RecipesController : BaseAPIController
    {

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRecipe( [FromBody]CreateRecipeRequest request)
        {
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRecipe(int id, [FromBody] RecipeDto Recipe)
        {
                return Ok();
        }
        public async Task<IActionResult> CreateRecipe([FromBody] CreateRecipeRequest request)
        {
            var recipe = await _mediator.Send(new AddRecipeCommand(request.Name, request.Directions, request.Ingredients));
            return Ok();
        }
        //maybe?
        [HttpPost("{id}")]
        public async Task<IActionResult> ImportRecipes(int id, [FromBody] List<RecipeDto> Recipe)
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecipe(int id)
        {
                return Ok();
        }
    }
}
