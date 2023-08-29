using Entities.Discriminators;
using Entities.Entity;
#pragma warning disable CS8618

namespace Entities.Abstract;

public class QuestCompleteConditionAbstract : BaseEntity
{
    public string Description { get; set; } = string.Empty;
    public QuestCompleteConditionDiscriminator CompleteConditionDiscriminator { get; set; }
    public virtual Quest TargetQuest { get; set; }
    public Guid TargetQuestId { get; set; }
}