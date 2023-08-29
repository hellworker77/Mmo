using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class TalentCharacterConfiguration : IEntityTypeConfiguration<TalentCharacter>
{
    public void Configure(EntityTypeBuilder<TalentCharacter> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Talent)
            .WithMany(x => x.TalentsCharacter)
            .HasForeignKey(x => x.TalentId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x=>x.Character)
            .WithMany(x=>x.TalentsCharacter)
            .HasForeignKey(x=>x.CharacterId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}