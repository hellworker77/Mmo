using Microsoft.AspNetCore.Identity;

namespace Common.IServices;

public interface IRoleService
{
    Task<IdentityResult> EnsureCreateAsync(string name,
        CancellationToken cancellationToken);
}