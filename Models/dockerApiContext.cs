using Microsoft.EntityFrameworkCore;

namespace dockerApi.Models
{
    public class dockerApiContext : DbContext
    {
        public dockerApiContext(DbContextOptions<dockerApiContext> options)
            : base(options)
        {
        }

        public DbSet<Input> Inputs { get; set; }
    }
}