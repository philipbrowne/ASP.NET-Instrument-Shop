using System.ComponentModel.DataAnnotations;

namespace InstrumentShop.Dtos 
{
    public class InstrumentCreateDto 
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        public string Family { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}