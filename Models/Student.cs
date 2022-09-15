using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Student.Models
{
    public class StudentInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; } = "";

        [Required]
        [StringLength(10)]
        public String Standard { get; set; } = "";

        [Required]
        [StringLength(150)]
        public string School { get; set; } = "";

        [Required (ErrorMessage = "Marks are mandatory") ]       
        public float  Marks { get; set; }

    }
}
