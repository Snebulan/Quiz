using Microsoft.EntityFrameworkCore;

namespace Quiz.Model
{
    public class Database : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Quiz> Quiz { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Answers> Answers { get; set; }
        public static string DBName = "database.db";

        // Constructor for DB - Ensure it's created
        public Database()
        {
            Database.EnsureCreated();
        }

        // Use our database string as data source
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=" + DBName);
        }

        // Ensure our database is created with seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(SeedData.Users);
            modelBuilder.Entity<Quiz>().HasData(SeedData.Quizes);
            modelBuilder.Entity<Questions>().HasData(SeedData.Questions);
            modelBuilder.Entity<Answers>().HasData(SeedData.Answers);
        }
    }
}
