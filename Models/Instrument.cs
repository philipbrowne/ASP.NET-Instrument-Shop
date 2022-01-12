using System.ComponentModel.DataAnnotations;

namespace InstrumentShop.Models 
{
    public class Instrument 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        public string Family { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}