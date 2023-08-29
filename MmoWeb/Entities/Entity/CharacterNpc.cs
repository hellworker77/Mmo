using Entities.Abstract;

#pragma warning disable CS8618
namespace Entities.Entity;

public class CharacterNpc : BaseEntity
{
    public virtual Npc Npc { get; set; }
    public Guid NpcId { get; set; }
    public virtual Character Character { get; set; }
    public Guid CharacterId { get; set; }
}