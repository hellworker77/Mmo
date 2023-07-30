using Common.IServices;
using Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Common.Services;

public class RoleService : IRoleService
{
    private readonly RoleManager<Role> _roleManager;

    public RoleService(RoleManager<Role> roleManager)
    {
        _roleManager = roleManager;
    }

    public async Task<IdentityResult> EnsureCreateAsync(string name,
        CancellationToken cancellationToken)
    {
        var role = new Role
        {
            Name = name, 
            ConcurrencyStamp = Guid.NewGuid().ToString("D")
        };
        var result = await _roleManager.CreateAsync(role);

        return result;
    }
}