using GraphQL.Dotnet.Entities.Context;

namespace GraphQL.Dotnet.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
