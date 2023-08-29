using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class TalentTreeConfiguration : IEntityTypeConfiguration<TalentTree>
{
    public void Configure(EntityTypeBuilder<TalentTree> builder)
    {
        builder.HasKey(x => x.Id);
    }
}