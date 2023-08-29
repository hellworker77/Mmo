using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class SkillCharacterConfiguration : IEntityTypeConfiguration<SkillCharacter>
{
    public void Configure(EntityTypeBuilder<SkillCharacter> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Character)
            .WithMany(x => x.SkillsCharacter)
            .HasForeignKey(x => x.CharacterId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x=>x.Skill)
            .WithMany(x=>x.SkillsCharacter)
            .HasForeignKey(x=>x.SkillId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}