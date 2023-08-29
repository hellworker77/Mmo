using Entities.Abstract;
using Entities.Enums;
using Entities.Identity;
#pragma warning disable CS8618

namespace Entities.Entity;

public class Character : BaseEntity
{
    public string Name { get; set; }
    public virtual IList<AuctionItem>? AuctionItems { get; set; }
    public virtual IList<ItemCustom>? CustomItems { get; set; }
    public virtual User User { get; set; }
    public Guid UserId { get; set; }
    public virtual GuildMember? GuildMember { get; set; }
    public virtual IList<Message>? Messages { get; set; }
    public virtual IList<ChannelCharacter>? ChannelsCharacter { get; set; }
    public virtual IList<TalentCharacter>? TalentsCharacter { get; set; }
    public virtual IList<SkillCharacter>? SkillsCharacter { get; set; }
    public virtual IList<CharacterNpc>? CharacterNpc { get; set; }
    public virtual IList<CharacterQuest>? CharacterQuests { get; set; }
    public virtual IList<CharacterLocation>? CharacterLocations { get; set; }
    public CharacterClass Class { get; set; }
}