using WebApi.Models;
using WebApi.Models.Tests;

namespace WebApi.Services.Tests;

public class TestService : ITestService
{
    public Task<Test> GetTest(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<GetTestShortDto>> GetAllTests()
    {
        throw new NotImplementedException();
    }

    public Task<Test> CreateTest(CreateTestRequestInfo dto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTest(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Test> UpdateTest(UpdateTestRequestInfo dto)
    {
        throw new NotImplementedException();
    }
}