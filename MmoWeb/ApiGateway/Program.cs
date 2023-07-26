
using Dal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace ApiGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "Ocelot API", Version = "v1" });
            });

            builder.Services.AddOcelot(builder.Configuration);

            builder.Services.AddDbContext<ApplicationContext>(optionsAction =>
            {
                optionsAction.UseNpgsql(builder.Configuration.GetConnectionString("entityDb"),
                    migration => migration.MigrationsAssembly(typeof(Program).Assembly.FullName));
                optionsAction.UseLazyLoadingProxies();
            });

            builder.Services.ConfigureAuthentication(builder.Configuration);

            builder.Services.ConfigureDbInitializer();

            var app = builder.Build();
            
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(x =>
                {
                    x.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                    x.RoutePrefix = "swagger";
                    x.DocExpansion(DocExpansion.None);
                });

                app.DbInitialize();
            }

            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();
            });

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseAuthentication();

            app.UseOcelot().Wait();

            app.MapControllers();

            app.Run();
        }
    }
}