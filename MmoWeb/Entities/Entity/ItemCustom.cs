using Entities.Abstract;
using Entities.Enums;

#pragma warning disable CS8618

namespace Entities.Entity;

public class ItemCustom : BaseEntity
{
    public virtual Item SourceItem { get; set; }
    public Guid SourceItemId { get; set; }
    public virtual Character Owner { get; set; }
    public Guid OwnerId { get; set; }
    public ItemBound BoundTo { get; set; }
    public virtual AuctionItem AuctionItem { get; set; }
}