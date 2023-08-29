using Entities.Discriminators;
using Entities.Entity;
#pragma warning disable CS8618

namespace Entities.Abstract;

public abstract class LocationQueueAbstract : BaseEntity
{
    public virtual Location Location { get; set; }
    public Guid LocationId { get; set; }
    public LocationQueueDiscriminator LocationQueueDiscriminator { get; set; }
}