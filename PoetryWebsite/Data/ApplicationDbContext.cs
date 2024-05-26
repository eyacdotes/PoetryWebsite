using Microsoft.EntityFrameworkCore;
using PoetryWebsite.Models;

namespace PoetryWebsite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Poetry> Poetries { get; set; }
    }
}
