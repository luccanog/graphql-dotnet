using GraphQL.Dotnet.Entities.Context;
using GraphQL.Dotnet.GraphQL;
using GraphQL.Dotnet.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Dotnet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddDbContext<AppDbContext>();

            builder.Services.AddGraphQL(config =>
            {
                config.AddSystemTextJson();
                config.AddSelfActivatingSchema<AppSchema>();
                config.AddErrorInfoProvider(opt => opt.ExposeExceptionDetails = true );
            });

            builder.Services.AddControllers();

            var app = builder.Build();

            // Apply database migrations during application startup
            using (var serviceScope = app.Services.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();
                context.Database.Migrate();
            }

            // Configure the HTTP request pipeline.
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseGraphQL<AppSchema>();
            app.UseGraphQLPlayground();

            app.MapControllers();

            app.Run();
        }
    }
}