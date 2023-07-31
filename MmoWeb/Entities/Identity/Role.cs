using Microsoft.AspNetCore.Identity;

namespace Entities.Identity;

public class Role : IdentityRole<Guid>
{
    public bool IsAvailableToPromote { get; set; }
}