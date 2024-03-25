using Microsoft.Build.Framework;

namespace WebApi.Models.Tests;

public class Question
{
    [Required] public Guid Id { get; set; }
    [Required] public string? Text { get; set; }
}