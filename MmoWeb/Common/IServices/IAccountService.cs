using Common.Models;
using Microsoft.AspNetCore.Identity;

namespace Common.IServices;

public interface IAccountService
{
    Task<UserDto> GetByIdAsync(Guid userId);

    Task<IdentityResult> RegisterAsync(string username, 
        string email, 
        string password, 
        string confirmedPassword);

    Task<IdentityResult> ChangeNameAsync(Guid userId, 
        string username);

    Task<IdentityResult> ChangeEmailAsync(Guid userId,
        string email);

    Task<IdentityResult> ChangePasswordAsync(Guid userId,
        string currentPassword,
        string password);
}