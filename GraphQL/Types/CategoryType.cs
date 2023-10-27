using GraphQL.Dotnet.Entities;
using GraphQL.Types;

namespace GraphQL.Dotnet.GraphQL.Types
{
    public class CategoryType : ObjectGraphType<Category>
    {
        public CategoryType()
        {
            Name = nameof(Category).ToLower();
            Description = "The product's category";
            
            Field(c => c.Id, type: typeof(IdGraphType))
                .Description("UUID identificator from Category object");

            Field(c => c.Name)
                .Description("Prop Name from Category object");

            Field(c => c.ImageUrl)
                .Description("Prop ImageURL from Category object");
        }
    }
}
