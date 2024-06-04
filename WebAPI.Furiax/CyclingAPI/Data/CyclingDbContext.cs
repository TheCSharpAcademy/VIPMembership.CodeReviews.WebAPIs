using Microsoft.EntityFrameworkCore;

namespace CyclingAPI.Data
{
    public class CyclingDbContext : DbContext
    {
        public CyclingDbContext(DbContextOptions options) : base(options) {}
    }
}
