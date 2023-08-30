using Entities.Discriminators;
using Entities.Entity;


namespace Entities.Abstract;

public abstract class MessageAbstract : BaseEntity
{
    public virtual IList<Media>? Attachments { get; set; }
    public virtual Character? Sender { get; set; }
    public Guid? SenderId { get; set; }
    public MessageDiscriminator MessageDiscriminator { get; set; }
    public string MessageMask { get; set; } = string.Empty;
    public string Inner { get; set; } = string.Empty;
    public DateTime? ChangedDate { get; set; }
    public DateTime PostedDate { get; set; }
}