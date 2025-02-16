using Microsoft.EntityFrameworkCore;

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
        public DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 1,
                FirstName = "Bart",
                LastName = "Simpson",
                DateofBirth = "1971-05-31",
                GPA = 2.7m,
                StudentSchoolNumber = 87654321
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 2,
                FirstName = "Lisa",
                LastName = "Simpson",
                DateofBirth = "1973-08-05",
                GPA = 2.2m,
                StudentSchoolNumber = 87654322
            });
        }
    }
}
