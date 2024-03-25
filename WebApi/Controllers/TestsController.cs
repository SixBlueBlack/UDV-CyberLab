using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Models.Tests;
using WebApi.Services.Tests;

namespace WebApi.Controllers;

[ApiController]
[Route("api/tests")]
public class TestsController : ControllerBase
{
    private readonly TestService testsService;

    [HttpGet("")]
    public async Task<ActionResult<List<GetTestShortDto>>> GetAllTests()
    {
        var tests = await testsService.GetAllTests().ConfigureAwait(false);
        return new ActionResult<List<GetTestShortDto>>(tests);
    }

    [HttpPost("")]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<Test>> CreateTest([FromRoute] CreateTestRequestInfo request)
    {
        var test = await testsService.CreateTest(request).ConfigureAwait(false);
        return new ActionResult<Test>(test);
    }

    [HttpGet("{id?}")]
    public async Task<ActionResult<Test>> GetTest(string id)
    {
        var test = await testsService.GetTest(Guid.Parse(id)).ConfigureAwait(false);
        return new ActionResult<Test>(test);
    }

    [HttpPatch("{id?}")]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<Test>> UpdateTest([FromRoute] UpdateTestRequestInfo request)
    {
        var test = await testsService.UpdateTest(request).ConfigureAwait(false);
        return new ActionResult<Test>(test);
    }

    [HttpDelete("{id?}")]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult> DeleteTest(string id)
    {
        await testsService.DeleteTest(Guid.Parse(id)).ConfigureAwait(false);
        return new StatusCodeResult(204);
    }
}