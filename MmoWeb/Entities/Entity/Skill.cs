using Entities.Abstract;

namespace Entities.Entity;

public class Skill : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public virtual Talent? Talent { get; set; }
    public virtual IList<SkillCharacter>? SkillsCharacter { get; set; }
    public virtual IList<SkillNpc>? SkillsNpc { get; set; }
    public string Description { get; set; } = string.Empty;
    public int MaximumLevel { get; set; }
}