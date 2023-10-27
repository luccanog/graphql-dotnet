using System.ComponentModel.DataAnnotations;

namespace GraphQL.Dotnet.DataTransferObjects
{
    public class CategoryDTO
    {
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        [Required]
        [MaxLength(300)]
        public string ImageUrl { get; set; }
    }
}
