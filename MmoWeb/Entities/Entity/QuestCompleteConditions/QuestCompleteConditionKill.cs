using Entities.Abstract;
#pragma warning disable CS8618

namespace Entities.Entity.QuestCompleteConditions;

public class QuestCompleteConditionKill : QuestCompleteConditionAbstract
{
    public virtual Npc TargetNpc { get; set; }
    public virtual Guid TargetNpcId { get; set; }
    public int TargetNpcCount { get; set; }
}