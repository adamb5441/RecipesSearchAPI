using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipesAPI.Application.Recipes;
using RecipesAPI.Application.Recipes.GetFullRecipe;

namespace RecipesAPI.API.Recipes
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RecipesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRecipe(Guid id)
        {
            var recipe = await _mediator.Send(new GetFullRecipeQuery(id));
            return Ok(recipe);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateRecipe(Guid id, [FromBody] RecipeRequest request)
        {
            var command = new ChangeRecipeCommand(id, request.Name, request.Directions, request.Ingredients);
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRecipe([FromBody] RecipeRequest request)
        {
            var command = new AddRecipeCommand(request.Name, request.Directions, request.Ingredients, request.Description, request.Yield);
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        //maybe?
        [HttpPost("Import")]
        public async Task<IActionResult> ImportRecipes([FromBody] List<RecipeRequest> Recipe)
        {
            return Ok();
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteRecipe(Guid id)
        {
            var response = await _mediator.Send(new RemoveRecipeCommand(id));
            return Ok(response);
        }
    }
}
