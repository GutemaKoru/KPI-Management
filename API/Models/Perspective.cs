using System;

namespace API.Models;

public class Perspective
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string Name { get; set; }
    public required decimal Weight { get; set; }
}
