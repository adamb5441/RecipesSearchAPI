using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;
using System;
using RecipesAPI.Domain.Recipes;

namespace RecipesAPI.Infrastructure
{
    public static class InfrastructureDependencies
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var url = "http://elastic-search:9200/";
            var defaultIndex = "Recipes";

            var settings = new ConnectionSettings(new Uri(url))
                .DefaultIndex(defaultIndex);


            settings.DefaultMappingFor<Recipe>(m => m);

            var client = new ElasticClient(settings);

            services.AddSingleton<IElasticClient>(client);

            client.Indices.Create(defaultIndex, index => index.Map<Recipe>(x => x.AutoMap())
            );
        }
    }
}
