using GraphQL.Dotnet.DataTransferObjects;
using GraphQL.Dotnet.Entities;
using GraphQL.Dotnet.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GraphQL.Dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _repository;

        public CategoryController(ICategoryRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public string Get()
        {
            return "Please use graphql to retrieve data.";
        }

        [HttpPost]
        public async Task<IActionResult> PostCategory([FromBody] CategoryDTO dto)
        {
            await _repository.Add(new Category
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                ImageUrl = dto.ImageUrl,
            });
            
            return NoContent();
        }
    }
}
