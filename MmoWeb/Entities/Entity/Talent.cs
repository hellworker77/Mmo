using Entities.Abstract;

namespace Entities.Entity;

public class Talent : BaseEntity
{
    public virtual IList<TalentCharacter>? TalentsCharacter { get; set; }
    public virtual IList<TalentToQueue>? TalentToQueues { get; set; }
    public virtual Skill? Skill { get; set; }
    public Guid? SkillId { get; set; }
    public int MaximumLevel { get; set; }
}