﻿using GraphQL.Dotnet.Entities;
using GraphQL.Dotnet.GraphQL.Types;
using GraphQL.Dotnet.Repositories;
using GraphQL.Types;

namespace GraphQL.Dotnet.GraphQL.Queries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery()
        {
            Field<CategoryType>(nameof(Category))
                .Resolve(context =>
                {
                    using var scope = context.RequestServices.CreateScope();
                    var repository = scope.ServiceProvider.GetRequiredService<ICategoryRepository>();
                    return repository.GetAll();
                });
        }
    }
}
