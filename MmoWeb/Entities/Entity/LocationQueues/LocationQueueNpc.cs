using Entities.Abstract;

#pragma warning disable CS8618
namespace Entities.Entity.LocationQueues;

public class LocationQueueNpc : LocationQueueAbstract
{
    public virtual Npc Npc { get; set; }
    public Guid NpcId { get; set; }
}