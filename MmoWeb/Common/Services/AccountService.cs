using Common.Exceptions.Account;
using Common.IServices;
using Common.Models;
using Entities.Identity;
using Mapster;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text;

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

    public async Task<UserDto> GetByIdAsync(Guid userId)
    {
        var source = await _userManager.Users
            .FirstOrDefaultAsync(x => x.Id == userId);

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
        string confirmedPassword)
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

        return await _userManager.CreateAsync(user, password);
    }

    public async Task<IdentityResult> ChangeNameAsync(Guid userId,
        string username)
    {
        var user = await _userManager.Users
            .FirstOrDefaultAsync(x => x.Id == userId);

        if (user == null)
        {
            throw new UserNotFoundException(userId);
        }

        return await _userManager.SetUserNameAsync(user, username);
    }

    public async Task<IdentityResult> ChangeEmailAsync(Guid userId,
        string email)
    {
        var user = await _userManager.Users
            .FirstOrDefaultAsync(x => x.Id == userId);

        if (user == null)
        {
            throw new UserNotFoundException(userId);
        }

        string token = await _userManager.GenerateChangeEmailTokenAsync(user, email);
        return await _userManager.ChangeEmailAsync(user, email, token);
    }

    public async Task<IdentityResult> ChangePasswordAsync(Guid userId,
        string currentPassword,
        string password)
    {
        var user = await _userManager.Users
            .FirstOrDefaultAsync(x => x.Id == userId);

        if (user == null)
        {
            throw new UserNotFoundException(userId);
        }

        return await _userManager.ChangePasswordAsync(user, currentPassword, password);
    }
}