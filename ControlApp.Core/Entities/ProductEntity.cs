﻿namespace ControlApp.Core.Entities;

public record ProductEntity : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Cost { get; set; }
    public int Count { get; set; }
    public string Manufacturer { get; set; }
    public string Description { get; set; }
    public string ImageName { get; set; }
}
