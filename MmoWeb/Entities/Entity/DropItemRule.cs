using Entities.Abstract;
#pragma warning disable CS8618

namespace Entities.Entity;

public class DropItemRule : BaseEntity
{
    public virtual Item Item { get; set; }
    public Guid ItemId { get; set; }
    public virtual Npc Npc { get; set; }
    public Guid NpcId { get; set; }
}