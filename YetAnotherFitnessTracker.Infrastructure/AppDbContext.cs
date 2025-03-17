using Microsoft.EntityFrameworkCore;
using YetAnotherFitnessTracker.Domain.Model;
using YetAnotherFitnessTracker.Infrastructure.Entity;

namespace YetAnotherFitnessTracker.Infrastructure;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
            
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Workout>().Property(w => w.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<Workout>().Property(w => w.Name).IsRequired();
        modelBuilder.Entity<Workout>().Property(w => w.Description).IsRequired();
        modelBuilder.Entity<Workout>().Property(w => w.Category).IsRequired();
        modelBuilder.Entity<Workout>().Property(w => w.CreatedAt).IsRequired();
        modelBuilder.Entity<Workout>().Property(w => w.UpdatedAt).IsRequired();
        modelBuilder.Entity<User>().Property(u => u.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<User>().Property(u => u.Name).IsRequired();
        modelBuilder.Entity<User>().Property(u => u.Password).IsRequired();
        modelBuilder.Entity<User>().Property(u => u.Email).IsRequired();
        modelBuilder.Entity<User>().HasMany<GoalStatus>(e => e.Goals);
        modelBuilder.Entity<User>().HasMany<WorkoutPlan>(e => e.WorkoutPlans);
        modelBuilder.Entity<WorkoutPlan>().Property(w => w.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<WorkoutPlan>().Property(w => w.Name).IsRequired();
        modelBuilder.Entity<WorkoutPlan>().Property(w => w.CreatedAt).IsRequired();
        modelBuilder.Entity<WorkoutPlan>().Property(w => w.UpdatedAt).IsRequired();
        modelBuilder.Entity<WorkoutPlan>().HasMany<Workout>(plan => plan.Workouts);
        modelBuilder.Entity<Goal>().Property(g => g.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<Goal>().Property(g => g.Name).IsRequired();
        modelBuilder.Entity<Goal>().Property(g => g.Description).IsRequired();
        modelBuilder.Entity<Goal>().Property(g => g.CreatedAt).IsRequired();
        modelBuilder.Entity<Goal>().Property(g => g.UpdatedAt).IsRequired();
        modelBuilder.Entity<Goal>().HasMany<GoalStatus>( e => e.Status);
        modelBuilder.Entity<GoalStatus>().Property(g => g.Id).ValueGeneratedOnAdd();
        modelBuilder.Entity<GoalStatus>().Property(g => g.IsCompleted).IsRequired();
        modelBuilder.Entity<GoalStatus>().Property(g => g.UpdatedAt).IsRequired();
        modelBuilder.Entity<GoalStatus>().Property(g => g.CreatedAt).IsRequired();
        
        
    }
    
    public DbSet<Workout> Workouts { get; set; }
    
}