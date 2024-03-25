using WebApi.Models;
using WebApi.Models.Tests;

namespace WebApi.Services.Tests;

public interface ITestService
{
    Task<Test> GetTest(Guid id);
    Task<List<GetTestShortDto>> GetAllTests();
    Task<Test> CreateTest(CreateTestRequestInfo dto);
    Task DeleteTest(Guid id);
    Task<Test> UpdateTest(UpdateTestRequestInfo dto);
}