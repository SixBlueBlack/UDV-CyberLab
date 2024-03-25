using Microsoft.AspNetCore.Mvc;

namespace WebApi.Models.Tests;

public class CreateOrUpdateTestDto
{
    [FromBody] public string? Title { get; set; }
    [FromBody] public string? Description { get; set; }
    [FromBody] public List<Question> Questions { get; set; } = new();
}