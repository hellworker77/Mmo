using Entities.Abstract;
using Entities.Enums;

#pragma warning disable CS8618
namespace Entities.Entity;

public class GuildAction : BaseEntity
{
    public GuildActionType ActionType { get; set; }
    public SecurityRoleActionLevel SecurityLevel { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual IList<GuildRoleAction> RoleActions { get; set; }
}