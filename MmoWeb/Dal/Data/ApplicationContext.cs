using Entities.Abstract;
using Entities.Entity;
using Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

// ReSharper disable IdentifierTypo
#pragma warning disable CS8618
namespace Dal.Data;

public class ApplicationContext : IdentityDbContext<User,
    Role,
    Guid,
    IdentityUserClaim<Guid>,
    IdentityUserRole<Guid>,
    IdentityUserLogin<Guid>,
    IdentityRoleClaim<Guid>,
    IdentityUserToken<Guid>>
{
    public DbSet<AuctionItem> AcquisitionItems { get; set; }
    public DbSet<Channel> Channels { get; set; }
    public DbSet<ChannelCharacter> ChannelsCharacter { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<CharacterLocation> CharacterLocations { get; set; }
    public DbSet<CharacterNpc> CharactersNpc { get; set; }
    public DbSet<CharacterQuest> CharacterQuests { get; set; }
    public DbSet<DropItemRule> DropItemsRule { get; set; }
    public DbSet<Guild> Guilds { get; set; }
    public DbSet<GuildAction> GuildActions { get; set; }
    public DbSet<GuildMember> GuildMembers { get; set; }
    public DbSet<GuildMemberRole> GuildMemberRoles { get; set; }
    public DbSet<GuildRole> GuildRoles { get; set; }
    public DbSet<GuildRoleAction> GuildRolesAction { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemCustom> ItemsCustom { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<LocationQueueAbstract> LocationsQueue { get; set; }
    public DbSet<Media> Medias { get; set; }
    public DbSet<MessageAbstract> Messages { get; set; }
    public DbSet<Npc> Npcs { get; set; }
    public DbSet<Quest> Quests { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SkillCharacter> SkillCharacters { get; set; }
    public DbSet<SkillNpc> SkillsNpc { get; set; }
    public DbSet<Talent> Talents { get; set; }
    public DbSet<TalentCharacter> TalentsCharacter { get; set; }
    public DbSet<TalentQueue> TalentsQueue { get; set; }
    public DbSet<TalentToQueue> TalentToQueues { get; set; }
    public DbSet<TalentTree> TalentTrees { get; set; }
    public DbSet<QuestCompleteConditionAbstract> QuestCompleteConditions { get; set; }
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}