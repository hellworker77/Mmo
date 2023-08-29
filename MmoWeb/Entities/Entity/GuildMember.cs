using Entities.Abstract;

#pragma warning disable CS8618
namespace Entities.Entity;

public class GuildMember : BaseEntity
{
    public string? Description { get; set; }
    public virtual Character Character { get; set; }
    public virtual Guild Guild { get; set; }
    public Guid GuildId { get; set; }
    public Guid CharacterId { get; set; }
    public virtual IList<GuildMemberRole> Roles { get; set; }
}