using GraphQL.Dotnet.Entities;
using GraphQL.Dotnet.GraphQL.Inputs;
using GraphQL.Dotnet.GraphQL.Types;
using GraphQL.Dotnet.Repositories;
using GraphQL.Types;

namespace GraphQL.Dotnet.GraphQL.Mutations
{
    public class AppMutation : ObjectGraphType
    {
        public AppMutation()
        {
            Field<CategoryType>("createCategory")
                .Argument<NonNullGraphType<CategoryInputType>>(nameof(Category))
                .Resolve(context =>
                {
                    using var scope = context.RequestServices!.CreateScope();
                    
                    var category = context.GetArgument<Category>("category");
                    category.Id = Guid.NewGuid();

                    var repository = scope.ServiceProvider.GetRequiredService<ICategoryRepository>();
                    repository.Add(category);

                    return category;
                });
        }
    }
}
