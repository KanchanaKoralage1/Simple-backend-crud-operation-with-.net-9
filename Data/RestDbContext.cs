using Microsoft.EntityFrameworkCore;
using RestApiProject.Models;

namespace RestApiProject.Data
{
    public class RestDbContext : DbContext
    {
        public RestDbContext(DbContextOptions<RestDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(

                new Book
                {
                    Id = 1,
                    Title = "The Great Gatsby",
                    Author = "kamal",
                    YearPublished = 2000
                },
             new Book
             {
                 Id = 2,
                 Title = "To kill a mockingbird",
                 Author = "perera",
                 YearPublished = 2000
             },
              new Book
              {
                  Id = 3,
                  Title = "1949",
                  Author = "sunil",
                  YearPublished = 2000
              },
               new Book
               {
                   Id = 4,
                   Title = "express",
                   Author = "harper",
                   YearPublished = 2000
               },
                  new Book
                  {
                      Id = 5,
                      Title = "victory",
                      Author = "harper",
                      YearPublished = 2000
                  }

                );
        }

        public DbSet<Book> Books { get; set; }
    }
}
