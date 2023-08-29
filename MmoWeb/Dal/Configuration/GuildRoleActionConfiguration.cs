using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class GuildRoleActionConfiguration : IEntityTypeConfiguration<GuildRoleAction>
{
    public void Configure(EntityTypeBuilder<GuildRoleAction> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.GuildAction)
            .WithMany(x => x.RoleActions)
            .HasForeignKey(x => x.GuildActionId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x=>x.GuildRole)
            .WithMany(x=>x.GuildRoleActions)
            .HasForeignKey(x=>x.GuildRoleId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}