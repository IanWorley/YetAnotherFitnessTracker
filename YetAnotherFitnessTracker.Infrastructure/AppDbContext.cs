using Microsoft.EntityFrameworkCore;
using YetAnotherFitnessTracker.Domain.Model;

namespace YetAnotherFitnessTracker.Infrastructure;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Workout> Workouts { get; set; }
    
}