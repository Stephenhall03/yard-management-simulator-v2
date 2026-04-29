using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace YardManagementSim.Data
{
    public class YardDbContextFactory : IDesignTimeDbContextFactory<YardDbContext>
    {
        public YardDbContext CreateDbContext(String[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<YardDbContext>();

            optionsBuilder.UseSqlite("Data Source=yard.db");

            return new YardDbContext(optionsBuilder.Options);
        }
    }
}
