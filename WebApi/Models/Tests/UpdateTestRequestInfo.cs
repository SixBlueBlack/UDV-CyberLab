using Microsoft.AspNetCore.Mvc;

namespace WebApi.Models.Tests;

public class UpdateTestRequestInfo
{
    [FromRoute] public Guid TestId { get; set; }
    [FromBody] public CreateOrUpdateTestDto Dto { get; set; }
}