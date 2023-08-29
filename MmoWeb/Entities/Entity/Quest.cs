using Entities.Abstract;
using Entities.Entity.LocationQueues;
#pragma warning disable CS8618

namespace Entities.Entity;

public class Quest : BaseEntity
{
    public string Name { get; set; }
    public virtual IList<CharacterQuest> CharacterQuests { get; set; }
    public virtual IList<QuestCompleteConditionAbstract> QuestCompleteConditions { get; set; }
    public virtual LocationQueueQuest? LocationQueue { get; set; }
}