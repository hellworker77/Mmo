using Account.Web.Tests.Fixture;
using Common.Services;
using Dal.Data;

namespace Account.Web.Tests.ServiceTests;

public class AccountServiceTests
{
    [Fact]
    public async Task GetByIdAsyncTestSuccessful()
    {
        await IdentityFixture.Instance.SeedUsersAsync();

        var service = new AccountService(IdentityFixture.Instance.UserManager, MapsterFixture.GetMapper());

        var excepted = FakeData.Users.First();

        var actual = await service.GetByIdAsync(excepted.Id, CancellationToken.None);

        Assert.Equal(excepted.Email, actual.Email);
    }
}