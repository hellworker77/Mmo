using Account.Web.Controllers;
using Common.IServices;
using Common.Models.Dtos;
using Moq;

namespace Account.Web.Tests.ControllerTests
{
    public class AccountControllerTest
    {
        [Fact]
        public async Task GetByIdAsyncSuccessfulTest()
        {
            var accountServiceMock = new Mock<IAccountService>();

            var identityServiceMock = new Mock<IIdentityService>();

            var userId = Guid.NewGuid();

            var cancellationToken = CancellationToken.None;

            var excepted = new UserDto { Email = "edwardGhom@gmail.com", UserName = "Edward" };

            accountServiceMock
                .Setup(x => x.GetByIdAsync(userId,
                    cancellationToken))
                .ReturnsAsync(excepted);

            var accountController = new AccountController(identityServiceMock.Object,
                accountServiceMock.Object);

            var destination = await accountController.GetUserByIdAsync(userId,
                cancellationToken);

            Assert.Equal(excepted, destination);
        }
    }
}