using Microsoft.EntityFrameworkCore;


namespace dictionary.Models
{
    public class EntryContext : DbContext
    {
        public EntryContext(DbContextOptions<EntryContext> options)
            : base(options)
        {
        }

        public DbSet<EntryItem> EntryItems { get; set; }
    }
}
