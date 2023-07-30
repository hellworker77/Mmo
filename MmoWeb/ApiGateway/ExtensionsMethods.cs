﻿using Dal.Data;
using Dal.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace ApiGateway;

internal static class ExtensionsMethods
{
    public static void ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        var identityUrl = configuration.GetValue<string>("IdentityUrl");
        var authenticationProviderKey = "IdentityApiKey";

        services.AddAuthentication()
            .AddJwtBearer(authenticationProviderKey, x =>
            {
                x.Authority = identityUrl;
                x.RequireHttpsMetadata = false;
                x.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidAudiences = new[] { "api", "account" }
                };
            });
    }
    public static void ConfigureDbInitializer(this IServiceCollection services)
    {
        services.AddTransient<IDbInitializer, DbInitializer>();
    }
    public static void DbInitialize(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();

        var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();

        dbInitializer.Initialize();
    }
}