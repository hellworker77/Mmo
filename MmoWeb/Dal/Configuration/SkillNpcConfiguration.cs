using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class SkillNpcConfiguration : IEntityTypeConfiguration<SkillNpc>
{
    public void Configure(EntityTypeBuilder<SkillNpc> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Skill)
            .WithMany(x => x.SkillsNpc)
            .HasForeignKey(x => x.SkillId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x=>x.Npc)
            .WithMany(x=>x.SkillsNpc)
            .HasForeignKey(x=>x.NpcId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}