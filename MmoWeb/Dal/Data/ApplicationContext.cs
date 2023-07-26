using Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Dal.Data;

public class ApplicationContext : IdentityDbContext<User,>
{
    
}