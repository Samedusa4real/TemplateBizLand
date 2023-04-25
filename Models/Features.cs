using System.ComponentModel.DataAnnotations;

namespace TemplateBizLand.Models
{
    public class Features
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string Header { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [MaxLength(25)]
        public string Icon { get; set; }
    }
}
