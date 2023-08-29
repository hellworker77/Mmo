using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class GuildRoleConfiguration : IEntityTypeConfiguration<GuildRole>
{
    public void Configure(EntityTypeBuilder<GuildRole> builder)
    {
        builder.HasKey(x => x.Id);
    }
}