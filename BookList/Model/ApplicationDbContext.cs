using Microsoft.EntityFrameworkCore;

namespace BookList.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)  
        {
                
        }
        public DbSet<Book> Book { get; set; }
    }
}
