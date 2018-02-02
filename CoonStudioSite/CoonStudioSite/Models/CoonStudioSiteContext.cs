using Microsoft.EntityFrameworkCore;

namespace CoonGamesSite.Models
{
    public class CoonStudioSiteContext : DbContext
    {
        public CoonStudioSiteContext(DbContextOptions<CoonStudioSiteContext> options) : base(options)
        {
        }

        public DbSet<BlogEntry> BlogEntries { get; set; }
    }
}
