using FifthTask.Models;
using Microsoft.EntityFrameworkCore;
namespace FifthTask.Data
{
    public class StudentDBContext : DbContext
    {
        public DbSet<Student> student { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FifthTask;Integrated Security=True;");
        }
    }
}