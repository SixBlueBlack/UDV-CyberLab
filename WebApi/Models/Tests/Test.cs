using Microsoft.Build.Framework;
using WebApi.Models.Tests;

namespace WebApi.Models;

public class Test
{
    [Required] public Guid Id { get; set; }

    [Required] public string? Title { get; set; }

    [Required] public List<Question> Questions { get; set; } = new();

    public string? Description { get; set; }
}