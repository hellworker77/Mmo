using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class TalentToQueueConfiguration : IEntityTypeConfiguration<TalentToQueue>
{
    public void Configure(EntityTypeBuilder<TalentToQueue> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Queue)
            .WithMany(x => x.TalentToQueues)
            .HasForeignKey(x => x.QueueId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x=>x.Talent)
            .WithMany(x=>x.TalentToQueues)
            .HasForeignKey(x=>x.TalentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}