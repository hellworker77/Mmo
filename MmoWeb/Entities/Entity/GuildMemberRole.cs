using Entities.Abstract;


#pragma warning disable CS8618
namespace Entities.Entity;

public class GuildMemberRole : BaseEntity
{
    public virtual GuildRole GuildRole { get; set; }
    public virtual GuildMember GuildMember { get; set; }
    public Guid GuildRoleId { get; set; }
    public Guid GuildMemberId { get; set; }
}