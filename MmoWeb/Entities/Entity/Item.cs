using Entities.Abstract;
using Entities.Entity.QuestCompleteConditions;

#pragma warning disable CS8618
namespace Entities.Entity;

public class Item : BaseEntity
{
    public string Name { get; set; }
    public virtual IList<DropItemRule>? DropItemRules { get; set; }
    public virtual IList<ItemCustom>? ItemCustoms { get; set; }
    public virtual IList<QuestCompleteConditionCollect>? QuestCompleteConditionsCollect { get; set; }
    public bool SoulBound { get; set; }
}