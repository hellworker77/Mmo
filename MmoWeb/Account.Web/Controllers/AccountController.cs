using Common.IServices;
using Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Account.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IIdentityService _identityService;
    private readonly IAccountService _accountService;

    public AccountController(IIdentityService identityService,
        IAccountService accountService)
    {
        _identityService = identityService;
        _accountService = accountService;
    }

    [HttpGet("id")]
    public async Task<UserDto> GetUserByIdAsync(Guid userId)
    {
        return await _accountService.GetByIdAsync(userId);
    }
}