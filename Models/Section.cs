using System.ComponentModel.DataAnnotations;

namespace Student.Models
{
    public class Section
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string? Name { get; set; } = null;
    }
}
