using Common.IServices;
using Common.Models.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
    public async Task<UserDto> GetUserByIdAsync(Guid userId,
        CancellationToken cancellationToken)
    {
        return await _accountService.GetByIdAsync(userId,
            cancellationToken);
    }

    [HttpPost("register")]
    public async Task<IdentityResult> RegisterAsync(string username, 
        string email,
        string password,
        string confirmedPassword,
        CancellationToken cancellationToken)
    {
        return await _accountService.RegisterAsync(username,
            email, 
            password,
            confirmedPassword,
            cancellationToken);
    }

    [Authorize]
    [HttpPut("changeUserName")]
    public async Task<IdentityResult> ChangeNameAsync(string username,
        CancellationToken cancellationToken)
    {
        var userId = _identityService.GetUserIdentity();

        return await _accountService.ChangeNameAsync(userId,
            username,
            cancellationToken);
    }

    [Authorize]
    [HttpPut("changeEmail")]
    public async Task<IdentityResult> ChangeEmailAsync(string email,
        CancellationToken cancellationToken)
    {
        var userId = _identityService.GetUserIdentity();

        return await _accountService.ChangeEmailAsync(userId,
            email,
            cancellationToken);
    }

    [Authorize]
    [HttpPut("changePassword")]
    public async Task<IdentityResult> ChangeEmailAsync(string password,
        string currentPassword,
        CancellationToken cancellationToken)
    {
        var userId = _identityService.GetUserIdentity();

        return await _accountService.ChangePasswordAsync(userId,
            currentPassword,
            password,
            cancellationToken);
    }
}