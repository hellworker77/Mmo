using Entities.Abstract;

#pragma warning disable CS8618
namespace Entities.Entity;

public class SkillNpc : BaseEntity
{
    public virtual Skill Skill { get; set; }
    public Guid SkillId { get; set; }
    public virtual Npc Npc { get; set; }
    public Guid NpcId { get; set; }
    public int CurrentLevel { get; set; }
}