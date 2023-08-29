using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class TalentQueueConfiguration : IEntityTypeConfiguration<TalentQueue>
{
    public void Configure(EntityTypeBuilder<TalentQueue> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Tree)
            .WithMany(x => x.Queues)
            .HasForeignKey(x => x.TreeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}