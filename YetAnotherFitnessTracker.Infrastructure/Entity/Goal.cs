using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using YetAnotherFitnessTracker.Domain.Model;

namespace YetAnotherFitnessTracker.Infrastructure.Entity;

public class Goal
{
    [Key]
    public Guid Id {get;set;}
    [StringLength(100)]
    public required string Name {get;set;} 
    
    [DefaultValue(false)]
    public required List<GoalStatus> Status {get;set;}
    
    public required string Description {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
}