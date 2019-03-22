using Microsoft.EntityFrameworkCore;

namespace dicci.forms.api.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<ListItem> Items { get; set; }
    }
}
