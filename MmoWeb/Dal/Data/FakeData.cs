using Entities.Identity;

namespace Dal.Data;

public static class FakeData
{
    public static ICollection<Role> Roles = new List<Role>
    {
        new Role
        {
            Name = "admin",
            NormalizedName = "ADMIN"
        }
    };
    public static ICollection<User> Users = new List<User>
    {
        new User()
        {
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
}