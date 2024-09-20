using ClassLibrary;
using System.Data.Entity;

namespace BookLibraryApp
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext() : base("name=LibraryDbContext") // Connection string name
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {  modelBuilder.Entity<Book>()
                .HasRequired(b => b.Author)   
                .WithMany(a => a.Books)       
                .HasForeignKey(b => b.AuthorId);

            base.OnModelCreating(modelBuilder); 
        }
    }
}
