using Entities.Abstract;
#pragma warning disable CS8618

namespace Entities.Entity;

public class CharacterQuest : BaseEntity
{
    public virtual Quest Quest { get; set; }
    public Guid QuestId { get; set; }
    public virtual Character Character { get; set; }
    public Guid CharacterId { get; set; }
}