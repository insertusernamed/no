using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using no.Models;

namespace no.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Library> Libraries { get; set; }

        public DbSet<Book> Books { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}