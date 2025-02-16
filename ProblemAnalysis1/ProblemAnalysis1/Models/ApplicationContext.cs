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
                FirstName = "Frank",
                LastName = "Jacob",
                DateofBirth = "1992-02-01",
                GPA = 3.2,
                StudentSchoolNumber = 87654321
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 2,
                FirstName = "Billy",
                LastName = "Joe",
                DateofBirth = "1997-04-03",
                GPA = 2.2,
                StudentSchoolNumber = 87654322
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 3,
                FirstName = "Timmy",
                LastName = "Short",
                DateofBirth = "1991-08-02",
                GPA = 1.3,
                StudentSchoolNumber = 87654323
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 4,
                FirstName = "Rachel",
                LastName = "Blake",
                DateofBirth = "2000-04-06",
                GPA = 3.2,
                StudentSchoolNumber = 87654324
            });
        }
    }
}
