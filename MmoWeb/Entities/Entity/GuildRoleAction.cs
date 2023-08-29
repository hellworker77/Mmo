using Entities.Abstract;

#pragma warning disable CS8618
namespace Entities.Entity;

public class GuildRoleAction: BaseEntity
{
    public virtual GuildRole GuildRole { get; set; }
    public virtual GuildAction GuildAction { get; set; }
    public Guid GuildActionId { get; set; }
    public Guid GuildRoleId { get; set; }
}