using Entities.Abstract;
using Entities.Enums;

#pragma warning disable CS8618
namespace Entities.Entity;

public class TalentTree : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public virtual CharacterClass AllowedClass { get; set; }
    public virtual IList<TalentQueue> Queues { get; set; }
}