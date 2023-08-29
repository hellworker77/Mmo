using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class GuildMemberConfiguration : IEntityTypeConfiguration<GuildMember>
{
    public void Configure(EntityTypeBuilder<GuildMember> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Character)
            .WithOne(x => x.GuildMember)
            .HasForeignKey<GuildMember>(x => x.CharacterId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x=>x.Guild)
            .WithMany(x=>x.Members)
            .HasForeignKey(x=>x.GuildId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}