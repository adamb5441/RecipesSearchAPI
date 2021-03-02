using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.API.Recipes
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RecipesController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRecipe(int id)
        {
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRecipe(int id, [FromBody] Recipe Recipe)
        {
                return Ok();
        }
        [HttpPost("{id}")]
        public async Task<IActionResult> CreateRecipe(int id, [FromBody] Recipe Recipe)
        {
            return Ok();
        }
        //maybe?
        [HttpPost("{id}")]
        public async Task<IActionResult> ImportRecipes(int id, [FromBody] Recipe Recipe)
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
