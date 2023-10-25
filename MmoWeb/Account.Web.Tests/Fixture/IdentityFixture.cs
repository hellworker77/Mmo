using Dal.Data;
using Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;

namespace Account.Web.Tests.Fixture;

public class IdentityFixture
{
    private readonly DbContextOptions<ApplicationContext> _options;
    private readonly ApplicationContext _context;
    private static IdentityFixture? _instance;

    public IdentityFixture()
    {
        _options = new DbContextOptionsBuilder<ApplicationContext>()
            .UseInMemoryDatabase(databaseName: "Account.Web.Test.DataBase")
            .Options;

        _context = new ApplicationContext(_options);

        UserManager = new UserManager<User>(
            new UserStore<User, Role, ApplicationContext, Guid>(_context),
            new Mock<IOptions<IdentityOptions>>().Object,
            new Mock<IPasswordHasher<User>>().Object,
            Array.Empty<IUserValidator<User>>(),
            Array.Empty<IPasswordValidator<User>>(),
            new Mock<ILookupNormalizer>().Object,
            new Mock<IdentityErrorDescriber>().Object,
            new Mock<IServiceProvider>().Object,
            new Mock<ILogger<UserManager<User>>>().Object);

    }
    public async Task SeedUsersAsync()
    {
        foreach (var user in FakeData.Users)
        {
            await UserManager.CreateAsync(user);
        }
    }

    public UserManager<User> UserManager { get; }
    public static IdentityFixture Instance => _instance ??= new IdentityFixture();
}