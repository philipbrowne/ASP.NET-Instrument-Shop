using System.ComponentModel.DataAnnotations;

namespace InstrumentShop.Dtos 
{
    public class InstrumentUpdateDto 
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        public string Family { get; set; }
        [Required]
        [Range(1.01, 1000000.00,
            ErrorMessage = "Price must be between 1.01 and 1000000.00")]
        public decimal Price { get; set; }
    }
}