using GraphQL.Dotnet.Entities;
using GraphQL.Dotnet.Entities.Context;

namespace GraphQL.Dotnet.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAll() => _context.Categories.ToList();
    }
}
