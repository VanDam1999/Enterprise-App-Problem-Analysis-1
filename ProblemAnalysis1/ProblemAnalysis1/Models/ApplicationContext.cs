using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace ProblemAnalysis1.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {

        }

        // Add constructor that accepts DbContextOptions<ApplicationContext> and passes it to the base class
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Program> Program { get; set; }
        public DbSet<Student> Student { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Program>().HasData(
                new Program
                {
                    Id = 1,
                    Key = "CP",
                    Name = "Computer Programmer"
                },
                new Program
                {
                    Id = 2,
                    Key = "CPA",
                    Name = "Computer Programmer Analyst"
                },
                new Program
                {
                    Id = 3,
                    Key = "BACS",
                    Name = "Bacheleor of Applied Computer Science"
                },
                new Program
                {
                    Id = 4,
                    Key = "BCS",
                    Name = "Bacheleor of Computer Science (Honours)"
                }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Bart",
                    LastName = "Simpson",
                    DateofBirth = "1971-05-31",
                    GPA = 2.7m,
                    StudentSchoolNumber = 87654321,
                    ProgramId = 1
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Lisa",
                    LastName = "Simpson",
                    DateofBirth = "1973-08-05",
                    GPA = 2.2m,
                    StudentSchoolNumber = 87654322,
                    ProgramId = 3
                }
            );
        }
    }
}
