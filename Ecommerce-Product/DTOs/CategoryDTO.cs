using System.ComponentModel.DataAnnotations;
using EcommerceMicroservice.Models;

namespace EcommerceMicroservice.DTOs
{
    public class CategoryDTO
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "O Nome é Requirido")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
