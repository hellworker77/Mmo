using Entities.Abstract;
using Entities.Entity.LocationQueues;
using Entities.Entity.QuestCompleteConditions;

#pragma warning disable CS8618
namespace Entities.Entity;

public class Npc : BaseEntity
{
    public virtual IList<SkillNpc>? SkillsNpc { get; set; }
    public virtual IList<CharacterNpc>? CharactersNpc { get; set; }
    public virtual IList<DropItemRule>? DropItemRules { get; set; }
    public virtual IList<QuestCompleteConditionKill>? QuestCompleteConditionsKill { get; set; }
    public virtual LocationQueueNpc LocationQueue { get; set; }
}