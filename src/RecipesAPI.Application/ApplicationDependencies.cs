﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace RecipesAPI.Application
{
    public static class ApplicationDependencies
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}