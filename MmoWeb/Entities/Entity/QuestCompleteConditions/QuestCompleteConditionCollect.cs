using Entities.Abstract;
#pragma warning disable CS8618

namespace Entities.Entity.QuestCompleteConditions;

public class QuestCompleteConditionCollect : QuestCompleteConditionAbstract
{
    public virtual Item TargetItem { get; set; }
    public virtual Guid TargetItemId { get; set; }
    public int TargetItemCount { get; set; }
}