using System.ComponentModel.DataAnnotations;

namespace StudentManagment.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Range(1, 150)]
        public int Age { get; set; }

        public string? Course { get; set; }
    }
}