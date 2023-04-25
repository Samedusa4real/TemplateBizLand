using System.ComponentModel.DataAnnotations;

namespace TemplateBizLand.Models
{
    public class TeamMembers
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Position { get; set; }
        [MaxLength(250)]
        public string Img { get; set; }
    }
}
