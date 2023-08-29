using Entities.Abstract;

#pragma warning disable CS8618
namespace Entities.Entity;

public class Channel : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public virtual IList<ChannelCharacter> ChannelCharacters { get; set; }
    public virtual IList<Message> Messages { get; set; }
}