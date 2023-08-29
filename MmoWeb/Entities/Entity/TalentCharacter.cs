using Entities.Abstract;

#pragma warning disable CS8618
namespace Entities.Entity;

public class TalentCharacter : BaseEntity
{
    public virtual Character Character { get; set; }
    public Guid CharacterId { get; set; }
    public virtual Talent Talent { get; set; }
    public Guid TalentId { get; set; }
    public int CurrentLevel { get; set; }
}