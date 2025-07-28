using System.ComponentModel.DataAnnotations;
using EcommerceMicroservice.Models;

namespace EcommerceMicroservice.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome é Requirido")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O Preço é Requirido")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "O Descrição é Requirido")]
        [MinLength(5)]
        [MaxLength(200)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "O Estoque é Requirido")]
        [Range(1, 9999)]
        public long Stock { get; set; }
        public string? ImageURL { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}
