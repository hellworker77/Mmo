using Entities.Abstract;

namespace Entities.Entity.Messages;

public class MessageChannel : MessageAbstract
{
    public virtual Channel? Channel { get; set; }
    public Guid? ChannelId { get; set; }
}