using CyclingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CyclingAPI.Data;

public class CyclingDbContext : DbContext
{
    public CyclingDbContext(DbContextOptions options) : base(options) 
    {
    }
    public DbSet<CyclingTrip> CyclingTrips { get; set; }
}

