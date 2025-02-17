using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProblemAnalysis1.Models
{
    public class Program
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Key { get; set; } = String.Empty;
        public string Name { get; set; } = String.Empty;
    }
}
