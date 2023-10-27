using GraphQL.Dotnet.GraphQL.Queries;
using GraphQL.Types;

namespace GraphQL.Dotnet.GraphQL
{
    public class AppSchema : Schema
    {
        public AppSchema(IServiceProvider provider)
        : base(provider)
        {
            Query = provider.GetRequiredService<AppQuery>();
        }
    }
}
