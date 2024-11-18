using Microsoft.EntityFrameworkCore;

namespace Lab10.Entities
{
    public class Lab10Context : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public Lab10Context(DbContextOptions<Lab10Context> options) : base(options) { }
    }
}
