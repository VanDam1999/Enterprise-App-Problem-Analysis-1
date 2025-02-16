using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProblemAnalysis1.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the students first name")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter the students last name")]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter the students date of birth")]
        public string DateofBirth { get; set; } = string.Empty;
        [Range(0.0, 4.0)]
        [Required(ErrorMessage = "Please enter the students GPA which must be between 0.0 - 4.0")]
        public double GPA { get; set; }
        [Length(8, 8)]
        [Required(ErrorMessage = "Please enter the students school number which must be eight digits")]
        public int StudentSchoolNumber { get; set; }
    }
}
