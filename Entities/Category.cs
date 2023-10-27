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

        public int CategoriaId { get; set; }

        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(300)]
        public string ImagemUrl { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
