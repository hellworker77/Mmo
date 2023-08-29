using Entities.Abstract;

#pragma warning disable CS8618
namespace Entities.Entity;

public class SkillCharacter : BaseEntity
{
    public virtual Character Character { get; set; }
    public Guid CharacterId { get; set; }
    public virtual Skill Skill { get; set; }
    public Guid SkillId { get; set; }
    public int CurrentLevel { get; set; }
}