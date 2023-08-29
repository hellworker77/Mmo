using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class GuildActionConfiguration : IEntityTypeConfiguration<GuildAction>
{
    public void Configure(EntityTypeBuilder<GuildAction> builder)
    {
        builder.HasKey(x => x.Id);
    }
}