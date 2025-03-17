namespace YetAnotherFitnessTracker.Domain.Model;

public class Workout
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Category { get; set; }
}