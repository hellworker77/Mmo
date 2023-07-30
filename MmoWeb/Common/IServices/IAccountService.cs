using Common.Models;
using Microsoft.AspNetCore.Identity;

namespace Common.IServices;

public interface IAccountService
{
    Task<UserDto> GetByIdAsync(Guid userId,
        CancellationToken cancellationToken);

    Task<IdentityResult> RegisterAsync(string username, 
        string email, 
        string password, 
        string confirmedPassword,
        CancellationToken cancellationToken);

    Task<IdentityResult> ChangeNameAsync(Guid userId, 
        string username,
        CancellationToken cancellationToken);

    Task<IdentityResult> ChangeEmailAsync(Guid userId,
        string email,
        CancellationToken cancellationToken);

    Task<IdentityResult> ChangePasswordAsync(Guid userId,
        string currentPassword,
        string password,
        CancellationToken cancellationToken);
}