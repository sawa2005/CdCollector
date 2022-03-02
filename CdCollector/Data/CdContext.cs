using CdCollector.Models;
using Microsoft.EntityFrameworkCore;

namespace CdCollector.Data
{
    public class CdContext : DbContext
    {
        public CdContext(DbContextOptions<CdContext> options) : base(options)
        {
        }

        public DbSet<Cd> Cd { get; set; }
        public DbSet<Artist> Artist { get; set; }
    }
}
