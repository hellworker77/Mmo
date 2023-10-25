using Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;

namespace Account.Web.Tests;

public static class ManagersMocks<T> where T : class
{
    public static Mock<UserManager<T>> CreateUserManagerMock()
    {
        var userManagerMock = new Mock<UserManager<T>>(
            new Mock<IUserStore<User>>().Object,
             new Mock<IOptions<IdentityOptions>>().Object,
             new Mock<IPasswordHasher<T>>().Object,
             new IUserValidator<T>[0],
             new IPasswordValidator<T>[0],
             new Mock<ILookupNormalizer>().Object,
             new Mock<IdentityErrorDescriber>().Object,
             new Mock<IServiceProvider>().Object,
             new Mock<ILogger<UserManager<T>>>().Object);

        return userManagerMock;
    }
}