using Entities.Abstract;

#pragma warning disable CS8618
namespace Entities.Entity;

public class Message : BaseEntity
{
    public virtual IList<Media>? Attachments { get; set; }
    public virtual Character Sender { get; set; }
    public virtual Channel Channel { get; set; }
    public Guid SenderId { get; set; }
    public Guid ChannelId { get; set; }
    public string MessageMask { get; set; } = string.Empty;
    public string Inner { get; set; } = string.Empty;
    public DateTime? EditedDate { get; set; }
    public DateTime PostedDate { get; set; }
}