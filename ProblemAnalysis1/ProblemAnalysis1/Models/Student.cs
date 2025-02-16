using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProblemAnalysis1.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DisplayName("First name")]
        [Required(ErrorMessage = "Please enter the students first name")]
        public string FirstName { get; set; } = string.Empty;
        [DisplayName("Last name")]
        [Required(ErrorMessage = "Please enter the students last name")]
        public string LastName { get; set; } = string.Empty;
        [DisplayName("Date of birth")]
        [Required(ErrorMessage = "Please enter the students date of birth")]
        public string DateofBirth { get; set; } = string.Empty;
        [Range(0.0, 4.0)]
        [Required(ErrorMessage = "Please enter the students GPA which must be between 0.0 - 4.0")]
        public decimal GPA { get; set; }
        [Range(10000000, 99999999)]
        [Required(ErrorMessage = "Please enter the students school number which must be eight digits")]
        public int StudentSchoolNumber { get; set; }

        public int StudentAge(string dob)
        {
            DateTime result;
            if (DateTime.TryParse(dob, out result))
            {
                return DateTime.Now.AddYears(-result.Year).Year;
            }
            return 0;
        }

        public string GPAScale(decimal gpa)
        {
            if ((float)gpa >= 3.7 && (float)gpa <= 4.0)
            {
                return "Excellent";
            }
            else if ((float)gpa >= 2.7 && (float)gpa <= 3.6)
            {
                return "Very Good";
            }
            else if ((float)gpa >= 1.7 && (float)gpa <= 2.6)
            {
                return "Good";
            }
            else if ((float)gpa >= 0.7 && (float)gpa <= 1.6)
            {
                return "Satisfactory";
            }
            return "Unsatisfactory";
        }
    }
}
