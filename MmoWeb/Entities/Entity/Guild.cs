using Entities.Abstract;

namespace Entities.Entity;

public class Guild : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public virtual IList<GuildRole>? Roles { get; set; }
    public virtual IList<GuildMember>? Members { get; set; }
    public DateTime CreatedAt { get; set; }
}