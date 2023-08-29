using Entities.Abstract;
#pragma warning disable CS8618

namespace Entities.Entity;

public class Location : BaseEntity
{
    public string Name { get; set; }
    public virtual IList<LocationQueueAbstract> LocationQueues { get; set; }
    public virtual IList<CharacterLocation>? CharacterLocations { get; set; }
}