namespace ControlApp.Core.Entities;

public record ProductFilter
{
    public required string SearchString { get; init; }
}