using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipesAPI.Application.Recipes;

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
            return Ok();
        }
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateRecipe(Guid id, [FromBody] RecipeDto Recipe)
        {
                return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRecipe([FromBody] CreateRecipeRequest request)
        {
            var command = new AddRecipeCommand(request.Name, request.Directions, request.Ingredients);
            var recipe = await _mediator.Send(command);
            return Ok();
        }
        //maybe?
        [HttpPost("Import")]
        public async Task<IActionResult> ImportRecipes([FromBody] List<RecipeDto> Recipe)
        {
            return Ok();
        }
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteRecipe(Guid id)
        {
                return Ok();
        }
    }
}
