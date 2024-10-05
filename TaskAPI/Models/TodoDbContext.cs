using Microsoft.EntityFrameworkCore;

namespace TaskAPI.Models
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MyTodoDb;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for Authors
            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author { Id = 1, FullName = "Manusha Gunathilaka", AddressNo = "12", Street = "Main St", City = "Colombo",JobRole="Developer" },
                new Author { Id = 2, FullName = "Methsara Dissanayaka", AddressNo = "34", Street = "Green Ave", City = "Kandy",JobRole="Systems Engineer" },
                new Author { Id = 3, FullName = "Kalpa Wishwajith", AddressNo = "56", Street = "Highland Rd", City = "Galle",JobRole="Developer" },
                new Author { Id = 4, FullName = "Kusal Mendis", AddressNo = "78", Street = "Lake View", City = "Negombo",JobRole="QA" }

            });

            // Seed data for Todos
            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
                new Todo
                {
                    Id = 1,
                    Title = "Complete Project Report",
                    Description = "Finish the report for the upcoming project deadline.",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.Status.New,
                    AuthorId= 1
                },
                new Todo
                {
                    Id = 2,
                    Title = "Prepare for Presentation",
                    Description = "Prepare slides and notes for Monday's presentation.",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(2),
                    Status = TodoStatus.Status.Inprogress,
                    AuthorId= 1
                },
                new Todo
                {
                    Id = 3,
                    Title = "Team Meeting",
                    Description = "Schedule a meeting with the team to discuss project progress.",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(3),
                    Status = TodoStatus.Status.New,
                    AuthorId= 2
                }
            });
        }
    }
}
