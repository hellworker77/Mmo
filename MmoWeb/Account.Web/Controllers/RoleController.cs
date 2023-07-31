using Common.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Account.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RoleController : ControllerBase
    {
        [HttpGet("roles")]
        public Task<IList<RoleDto>> GetRolesAsync()
        {
            throw new NotImplementedException();
        }
        [Authorize(Roles = "admin,moderator")]
        [HttpPut("promote")]
        public Task<IdentityResult> PromoteToRoleAsync()
        {
            throw new NotImplementedException();
        }
    }
}
