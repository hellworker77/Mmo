using Common.Exceptions.Account;
using Common.IServices;
using Common.Models;
using Entities.Identity;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Common.Services;

public class AccountService : IAccountService
{
    private readonly UserManager<User> _userManager;
    private readonly IMapper _mapper;

    public AccountService(UserManager<User> userManager,
        IMapper mapper)
    {
        _userManager = userManager;
        _mapper = mapper;  
    }

    public async Task<UserDto> GetByIdAsync(Guid userId,
        CancellationToken cancellationToken)
    {
        var source = await _userManager.Users
            .FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);

        if (source == null)
        {
            throw new UserNotFoundException(userId);
        }

        var destination = _mapper.Map<UserDto>(source);

        return destination;
    }

    public async Task<IdentityResult> RegisterAsync(string username,
        string email,
        string password,
        string confirmedPassword,
        CancellationToken cancellationToken)
    {
        if (password != confirmedPassword)
        {
            throw new PasswordNotEqualsException();
        }

        var user = new User
        {
            UserName = username,
            Email = email,
            EmailConfirmed = false
        };
        await _userManager.CreateAsync(user, password);

        return await _userManager.AddToRoleAsync(user, "user");
    }

    public async Task<IdentityResult> ChangeNameAsync(Guid userId,
        string username,
        CancellationToken cancellationToken)
    {
        var user = await _userManager.Users
            .FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);

        if (user == null)
        {
            throw new UserNotFoundException(userId);
        }

        return await _userManager.SetUserNameAsync(user, username);
    }

    public async Task<IdentityResult> ChangeEmailAsync(Guid userId,
        string email,
        CancellationToken cancellationToken)
    {
        var user = await _userManager.Users
            .FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);

        if (user == null)
        {
            throw new UserNotFoundException(userId);
        }

        string token = await _userManager.GenerateChangeEmailTokenAsync(user, email);
        return await _userManager.ChangeEmailAsync(user, email, token);
    }

    public async Task<IdentityResult> ChangePasswordAsync(Guid userId,
        string currentPassword,
        string password,
        CancellationToken cancellationToken)
    {
        var user = await _userManager.Users
            .FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);

        if (user == null)
        {
            throw new UserNotFoundException(userId);
        }

        return await _userManager.ChangePasswordAsync(user, currentPassword, password);
    }
}