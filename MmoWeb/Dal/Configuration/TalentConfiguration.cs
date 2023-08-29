using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class TalentConfiguration : IEntityTypeConfiguration<Talent>
{
    public void Configure(EntityTypeBuilder<Talent> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Skill)
            .WithOne(x => x.Talent)
            .HasForeignKey<Talent>(x => x.SkillId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}