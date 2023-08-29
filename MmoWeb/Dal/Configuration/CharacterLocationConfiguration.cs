using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class CharacterLocationConfiguration : IEntityTypeConfiguration<CharacterLocation>
{
    public void Configure(EntityTypeBuilder<CharacterLocation> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Character)
            .WithMany(x => x.CharacterLocations)
            .HasForeignKey(x => x.CharacterId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x=>x.Location)
            .WithMany(x=>x.CharacterLocations)
            .HasForeignKey(x=>x.LocationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}