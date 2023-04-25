using System.ComponentModel.DataAnnotations;

namespace TemplateBizLand.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Price { get; set; }

    }
}
