using GraphQL.Dotnet.Entities;
using GraphQL.Types;

namespace GraphQL.Dotnet.GraphQL.Inputs
{
    public class CategoryInputType : InputObjectGraphType
    {
        public CategoryInputType()
        {
            Name = "CategoryInput";
            Field<NonNullGraphType<StringGraphType>>(nameof(Category.Name));
            Field<NonNullGraphType<StringGraphType>>(nameof(Category.ImageUrl));
        }
    }
}
