using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace GraphQL.Dotnet.Entities
{
    public class Category
    {
        public Category()
        {
            Products = new Collection<Product>();
        }

        public Guid Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        [Required]
        [MaxLength(300)]
        public string ImageUrl { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
