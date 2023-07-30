using Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Dal.Data;

public static class FakeData
{
    public static ICollection<Role> Roles = new List<Role>
    {
        new Role
        {
            Id = Guid.NewGuid(),
            Name = "admin",
            NormalizedName = "ADMIN",
            ConcurrencyStamp = Guid.NewGuid().ToString("D")
        }
    };
    public static ICollection<User> Users = new List<User>
    {
        new User()
        {
            Id = Guid.NewGuid(),
            Email = "admin@aaa.com",
            NormalizedEmail = "ADMIN@AAA.COM",
            UserName = "admin",
            NormalizedUserName = "ADMIN",
            EmailConfirmed = true,
            PasswordHash =
                "AQAAAAIAAYagAAAAEOObrxK8MEi9CAr6V1lm3CjQwpdMWO46J15/fN4AshwLh45ThOxSLoOFh1id4JNFQA==", // !QAZ2wsx
            SecurityStamp = Guid.NewGuid().ToString("D")
        }
    };

    public static ICollection<IdentityUserRole<Guid>> UserRoles = new List<IdentityUserRole<Guid>>
    {
        new IdentityUserRole<Guid>
        {
            UserId = Users.FirstOrDefault()!.Id,
            RoleId = Roles.FirstOrDefault()!.Id
        }
    };
}