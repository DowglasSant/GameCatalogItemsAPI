using System.ComponentModel.DataAnnotations;

namespace Catalog.DTOs
{
    public record CreateItemDto
    {
        [Required]
        public string Name { get; init; }

        [Required]
        [Range(1, 9999)]
        public decimal Price { get; init; }

        [Required]
        public string Percentage { get; init; }
    }
}