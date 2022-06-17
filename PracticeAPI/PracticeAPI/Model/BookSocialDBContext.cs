using Microsoft.EntityFrameworkCore;

namespace PracticeAPI.Model
{
    public class BookSocialDBContext : DbContext
    {
        public BookSocialDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
        }
    }
}
