using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesAPI.Application.Recipes
{
    class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<RecipeDto, RecipeDto>();
        }
    }
}
