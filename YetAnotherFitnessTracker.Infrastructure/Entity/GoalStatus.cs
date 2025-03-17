using System.ComponentModel.DataAnnotations;

namespace YetAnotherFitnessTracker.Infrastructure.Entity;

public class GoalStatus
{
    [Key]
    public Guid Id {get;set;}
    public bool IsCompleted {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
    
    
}