using GraphQL.Dotnet.Entities.Context;
using GraphQL.Dotnet.GraphQL;
using GraphQL.Dotnet.GraphQL.Queries;
using GraphQL.Dotnet.GraphQL.Types;
using GraphQL.Dotnet.Repositories;
using GraphQL.MicrosoftDI;
using GraphQL.Types;

namespace GraphQL.Dotnet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<AppDbContext>();

            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();

            builder.Services.AddSingleton<AppQuery>();
            builder.Services.AddSingleton<CategoryType>();

            builder.Services.AddSingleton<ISchema, AppSchema>(services => new AppSchema(new SelfActivatingServiceProvider(services)));

            builder.Services.AddGraphQL(config =>
            {
                config.AddSystemTextJson();
                config.AddSchema<AppSchema>();
            });


            var app = builder.Build();

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