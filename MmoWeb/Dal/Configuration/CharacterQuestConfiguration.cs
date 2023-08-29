using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class CharacterQuestConfiguration : IEntityTypeConfiguration<CharacterQuest>
{
    public void Configure(EntityTypeBuilder<CharacterQuest> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Quest)
            .WithMany(x => x.CharacterQuests)
            .HasForeignKey(x => x.QuestId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x=>x.Character)
            .WithMany(x=>x.CharacterQuests)
            .HasForeignKey(x=>x.CharacterId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}