using Entities.Abstract;
using Entities.Enums;

#pragma warning disable CS8618
namespace Entities.Entity;

public class TalentToQueue : BaseEntity
{
    public virtual TalentQueue Queue { get; set; }
    public Guid QueueId { get; set; }
    public virtual Talent Talent { get; set; }
    public Guid TalentId { get; set; }
    public TalentFlag Flag { get; set; }
    public int NeedTo { get; set; }
    public int Index { get; set; }
}

