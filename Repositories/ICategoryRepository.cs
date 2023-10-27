using GraphQL.Dotnet.Entities;

namespace GraphQL.Dotnet.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
    }
}
