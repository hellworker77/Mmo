using Entities.Abstract;

#pragma warning disable CS8618
namespace Entities.Entity.LocationQueues;

public class LocationQueueQuest : LocationQueueAbstract
{
    public virtual Quest Quest { get; set; }
    public Guid QuestId { get; set; }
}