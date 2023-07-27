using Common.Exceptions.Account;
using Common.IServices;
using Microsoft.AspNetCore.Http;

namespace Common.Services;

public class IdentityService : IIdentityService
{
    private readonly IHttpContextAccessor _accessor;

    public IdentityService(IHttpContextAccessor accessor)
    {
        _accessor = accessor;
    }

    public Guid GetUserIdentity()
    {
        var userIdentity = _accessor.HttpContext.User.FindFirst("sub")?.Value;

        if (userIdentity == null)
        {
            throw new UserIdentityNullException();
        }

        return Guid.Parse(userIdentity);

    }
}