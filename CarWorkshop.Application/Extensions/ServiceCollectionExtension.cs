﻿using CarWorkshop.Application.MappingProfiles;
using CarWorkshop.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CarWorkshop.Application.Extensions;

public static class ServiceCollectionExtension
{
    public static void AddApplicationConfig(this IServiceCollection services)
    {
        services.AddScoped<ICarWorkshopService, CarWorkshopService>();
        // services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        // or
        services.AddAutoMapper(typeof(CarWorkshopMappingProfile));
    }
    
}