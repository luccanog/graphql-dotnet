using System.ComponentModel.DataAnnotations;

namespace GraphQL.Dotnet.Entities
{
    public class Product
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        public decimal Value { get; set; }

        [Required]
        [StringLength(300)]
        public string ImageUrl { get; set; }

        public float Quantity { get; set; }

        public DateTime CreationDate { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }
    }
}
