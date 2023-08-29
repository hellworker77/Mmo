using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class GuildMemberRoleConfiguration : IEntityTypeConfiguration<GuildMemberRole>
{
    public void Configure(EntityTypeBuilder<GuildMemberRole> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.GuildRole)
            .WithMany(x => x.GuildMemberRoles)
            .HasForeignKey(x => x.GuildRoleId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x=>x.GuildMember)
            .WithMany(x=>x.Roles)
            .HasForeignKey(x=>x.GuildMemberId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}