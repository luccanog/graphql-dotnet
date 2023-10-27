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

        public async Task Add(Category category)
        {
            await _context.Categories.AddAsync(category);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetAll() => _context.Categories.ToList();
    }
}
