using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class ChannelCharacterConfiguration : IEntityTypeConfiguration<ChannelCharacter>
{
    public void Configure(EntityTypeBuilder<ChannelCharacter> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Channel)
            .WithMany(x => x.ChannelCharacters)
            .HasForeignKey(x => x.ChannelId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x=>x.Character)
            .WithMany(x=>x.ChannelsCharacter)
            .HasForeignKey(x=>x.CharacterId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}