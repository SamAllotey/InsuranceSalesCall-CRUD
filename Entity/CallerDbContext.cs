using MariaAndSonsInsLtd.Models;
using Microsoft.EntityFrameworkCore;

namespace MariaAndSonsInsLtd.Entity
{
    public class CallerDbContext : DbContext
    {
        public CallerDbContext(DbContextOptions<CallerDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Caller> Callers { get; set; }
    }
}
