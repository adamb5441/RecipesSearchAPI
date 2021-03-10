using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesAPI.API;
using RecipesAPI.Application.Searches.AnonymousSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.API.Search
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : BaseAPIController
    {
        private readonly IMediator _mediator;

        public SearchController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("OpenSearch")]
        public async Task<IActionResult> OpenSearch(string query, int page = 1, int pageSize = 5)
        {
            var response = await _mediator.Send(new AnonymousSearchQuery(query, page, pageSize));

            return Ok(response);
        }
    }
}
