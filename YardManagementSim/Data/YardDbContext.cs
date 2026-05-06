using Microsoft.EntityFrameworkCore;
using YardManagementSim.Models;

namespace YardManagementSim.Data
{
    public class YardDbContext : DbContext
    {
        public YardDbContext(DbContextOptions<YardDbContext> options) : base(options)
        {
        }

        public DbSet<YardSlot> YardSlots { get; set; }
        public DbSet<YardMove> YardMoves { get; set; }
    }
}
