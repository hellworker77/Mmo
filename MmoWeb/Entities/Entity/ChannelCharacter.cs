using Entities.Abstract;

#pragma warning disable CS8618
namespace Entities.Entity;

public class ChannelCharacter : BaseEntity
{
    public virtual Channel Channel { get; set; }
    public virtual Character Character { get; set; }
    public Guid ChannelId { get; set; }
    public Guid CharacterId { get; set; }

}