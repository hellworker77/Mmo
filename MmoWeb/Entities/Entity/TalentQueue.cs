using Entities.Abstract;

#pragma warning disable CS8618
namespace Entities.Entity;

public class TalentQueue : BaseEntity
{
    public virtual IList<TalentToQueue> TalentToQueues { get; set; }
    public virtual TalentTree Tree { get; set; }
    public Guid TreeId { get; set; }
}