using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;
using System;
using RecipesAPI.Domain.Recipes;

namespace RecipesAPI.Infrastructure
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var url = "http://elastic-search:9200/";
        var defaultIndex = "Recipes";

        var settings = new ConnectionSettings(new Uri(url))
            .DefaultIndex(defaultIndex);

        AddDefaultMappings(settings);

        var client = new ElasticClient(settings);

        services.AddSingleton<IElasticClient>(client);

        CreateIndex(client, defaultIndex);
    }
    private static void AddDefaultMappings(ConnectionSettings settings)
    {
        settings.
            DefaultMappingFor<Recipe>(m => m);
    }
    private static void CreateIndex(IElasticClient client, string indexName)
    {
        var createIndexResponse = client.Indices.Create(indexName,
            index => index.Map<Recipe>(x => x.AutoMap())
        );
    }
}
