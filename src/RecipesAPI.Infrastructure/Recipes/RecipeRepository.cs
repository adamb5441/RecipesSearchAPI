﻿using RecipesAPI.Domain.Recipes;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesAPI.Infrastructure.Recipes
{
    class RecipeRepository : IRecipeRepository
    {
        private readonly IElasticClient _elasticClient;

        public RecipeRepository(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        //public async virtual Task<Recipe[]> SearchRecipesPage(string query, int page, int pageSize)
        //{
        //    var response = await _elasticClient.SearchAsync<Recipe>(s =>
        //        s.Query(q => q.QueryString(d => d.Query('*' + query + '*')))
        //        .From((page - 1) * pageSize)
        //        .Size(pageSize));
        //    if (!response.IsValid)
        //    {
        //        return new Recipe[] { };
        //    }

        //    return response.Documents.ToArray();
        //}

        public async virtual Task<Recipe> GetRecipeById(Guid id)
        {
            var response = await _elasticClient.GetAsync<Recipe>(id, idx => idx.Index("recipes"));
            return response.Source;
        }

        public async Task DeleteAsync(Recipe Recipe)
        {
            await _elasticClient.DeleteAsync<Recipe>(Recipe);

        }

        public async Task SaveSingleAsync(Recipe Recipe)
        {

            var response = await _elasticClient.IndexDocumentAsync<Recipe>(Recipe);
            Console.WriteLine("Done");
        }

        public async Task SaveBulkAsync(Recipe[] Recipes)
        {
            await _elasticClient.BulkAsync(b => b.Index("Recipes").IndexMany(Recipes));
        }
    }
}
