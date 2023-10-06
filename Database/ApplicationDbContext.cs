using Microsoft.EntityFrameworkCore;
using NobeliumBooksApp.Models;

namespace NobeliumBooksApp.Database
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
    }
}
 