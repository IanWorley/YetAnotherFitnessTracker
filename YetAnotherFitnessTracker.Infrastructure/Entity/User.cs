using System.ComponentModel.DataAnnotations;
using YetAnotherFitnessTracker.Infrastructure.Entity;

namespace YetAnotherFitnessTracker.Domain.Model;

public class User
{
    [Key]
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string  Password { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required DateTime UpdatedAt { get; set; }
    public List<WorkoutPlan> WorkoutPlans { get; set; }
    public List<GoalStatus> Goals { get; set; }
}