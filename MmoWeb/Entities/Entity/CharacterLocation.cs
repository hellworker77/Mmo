using Entities.Abstract;
#pragma warning disable CS8618

namespace Entities.Entity;

public class CharacterLocation : BaseEntity
{
    public virtual Character Character { get; set; }
    public Guid CharacterId { get; set; }
    public virtual Location Location { get; set; }
    public Guid LocationId { get; set; }
}