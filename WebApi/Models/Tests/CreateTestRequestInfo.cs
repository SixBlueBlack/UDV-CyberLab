using Microsoft.AspNetCore.Mvc;

namespace WebApi.Models.Tests;

public class CreateTestRequestInfo
{
    [FromBody] private CreateOrUpdateTestDto Dto { get; set; }
}