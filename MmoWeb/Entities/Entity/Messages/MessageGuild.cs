using Entities.Abstract;

namespace Entities.Entity.Messages;

public class MessageGuild : MessageAbstract
{
    public virtual Guild? Guild { get; set; }
    public Guid? GuildId { get; set; }
}