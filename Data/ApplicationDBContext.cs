using dotNetMastery.Models;
using Microsoft.EntityFrameworkCore;

namespace dotNetMastery.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 7, Name = "New Test", DisplayOrder=7},
                 new Category { Id = 8, Name = "New Test", DisplayOrder = 8}
                );
        }
    }
}
