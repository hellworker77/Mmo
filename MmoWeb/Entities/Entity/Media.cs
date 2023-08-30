using Entities.Abstract;

#pragma warning disable CS8618
namespace Entities.Entity;

public class Media : BaseEntity
{
    public string Data { get; set; } = string.Empty;
    public virtual MessageAbstract Message { get; set; }
    public Guid MessageId { get; set; }
}