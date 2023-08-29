using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class CharacterNpcConfiguration : IEntityTypeConfiguration<CharacterNpc>
{
    public void Configure(EntityTypeBuilder<CharacterNpc> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Character)
            .WithMany(x => x.CharacterNpc)
            .HasForeignKey(x => x.CharacterId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x=>x.Npc)
            .WithMany(x=>x.CharactersNpc)
            .HasForeignKey(x=>x.NpcId)
            .OnDelete(DeleteBehavior.Cascade);

    }
}