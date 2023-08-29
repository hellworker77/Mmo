using Entities.Abstract;
#pragma warning disable CS8618

namespace Entities.Entity;

public class AuctionItem : BaseEntity
{
    public virtual Character AuctionOwner { get; set; }
    public Guid AuctionOwnerId { get; set; }
    public virtual ItemCustom SourceItemCustom { get; set; }
    public Guid SourceItemCustomId { get; set; }

}