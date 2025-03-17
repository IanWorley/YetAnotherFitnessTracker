

using System.ComponentModel.DataAnnotations;

namespace YetAnotherFitnessTracker.Infrastructure.Entity;

public class WorkoutPlan
{
    [Key]
    public Guid Id {get;set;}
    
    public  List<Workout> Workouts { get; set; }
    public required string Name { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required DateTime UpdatedAt { get; set; }
    
    
    
}