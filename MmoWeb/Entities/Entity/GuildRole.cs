using Entities.Abstract;

#pragma warning disable CS8618
namespace Entities.Entity;

public class GuildRole : BaseEntity
{
    public string Name { get; set; } = "Role name";
    public string ColorHex { get; set; } = "#fff";
    public virtual IList<GuildRoleAction> GuildRoleActions { get; set; }
    public virtual IList<GuildMemberRole> GuildMemberRoles { get; set; }
}