
using System.Reflection;
using Dal.Data;
using Entities.Identity;
using Identity.Web.Config;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Identity.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var policyName = "allowAll";

            var builder = WebApplication.CreateBuilder(args);
            

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(policyName,
                    policy =>
                    {
                        policy
                            .AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });

            var migrationAssembly = typeof(Program).GetTypeInfo().Assembly.GetName().Name;

            builder.Services.AddDbContext<ApplicationContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("entityDb"),
                    migration => migration.MigrationsAssembly(migrationAssembly)));

            builder.Services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<ApplicationContext>()
                .AddRoleManager<RoleManager<Role>>()
                .AddUserManager<UserManager<User>>()
                .AddDefaultTokenProviders();


            builder.Services.AddIdentityServer(options =>
                {
                    options.UserInteraction.LoginUrl = null;
                })
                .AddConfigurationStore(options =>
                {
                    options.ConfigureDbContext = context =>
                        context.UseNpgsql(builder.Configuration.GetConnectionString("configurationDb"),
                            migration => migration.MigrationsAssembly(migrationAssembly));
                })
                .AddOperationalStore(options =>
                {
                    options.ConfigureDbContext = context =>
                        context.UseNpgsql(builder.Configuration.GetConnectionString("operationalDb"),
                            migration => migration.MigrationsAssembly(migrationAssembly));
                })
                .AddDeveloperSigningCredential()
                .AddAspNetIdentity<User>();

            var app = builder.Build();

            app.InitializeDatabase();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors(policyName);

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseIdentityServer();

            app.MapControllers();

            app.Run();
        }
    }
}