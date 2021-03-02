﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipesAPI.API.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAPI.API.Search
{

    public class SearchController : BaseAPIController
    {
        private readonly IMediator _mediator;

        public SearchController(IMediator mediator)
        {
            this._mediator = mediator;
        }
    }
}
