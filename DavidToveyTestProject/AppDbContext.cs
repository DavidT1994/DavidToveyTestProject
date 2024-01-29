using DavidToveyTestProject.Models;
using Microsoft.EntityFrameworkCore;

namespace David_Tovey_Test_Project
{
    public class AppDbContext : DbContext
    {

        public AppDbContext() : base()
        {

        }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Students> Students => Set<Students>();
        public DbSet<Subjects> Subjects => Set<Subjects>();
        public DbSet<StudentSubjects> StudentSubjects => Set<StudentSubjects>();
    }
}