using Common.IServices;
using Common.Models;
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
    public async Task<UserDto> GetUserByIdAsync(Guid userId)
    {
        return await _accountService.GetByIdAsync(userId);
    }
    [HttpPost("register")]
    public async Task<IdentityResult> RegisterAsync(string username, 
        string email,
        string password,
        string confirmedPassword)
    {
        return await _accountService.RegisterAsync(username, email, password, confirmedPassword);
    }
    [Authorize]
    [HttpPut("changeUserName")]
    public async Task<IdentityResult> ChangeNameAsync(string username)
    {
        var userId = _identityService.GetUserIdentity();

        return await _accountService.ChangeNameAsync(userId, username);
    }
    [Authorize]
    [HttpPut("changeEmail")]
    public async Task<IdentityResult> ChangeEmailAsync(string email)
    {
        var userId = _identityService.GetUserIdentity();

        return await _accountService.ChangeEmailAsync(userId, email);
    }
    [Authorize]
    [HttpPut("changePassword")]
    public async Task<IdentityResult> ChangeEmailAsync(string password,
        string currentPassword)
    {
        var userId = _identityService.GetUserIdentity();

        return await _accountService.ChangePasswordAsync(userId, currentPassword, password);
    }
}