using Entities.Abstract;
using Entities.Discriminators;
using Entities.Entity.LocationQueues;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class LocationQueueQuestConfiguration : IEntityTypeConfiguration<LocationQueueQuest>
{
    public void Configure(EntityTypeBuilder<LocationQueueQuest> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasBaseType<LocationQueueAbstract>()
            .HasDiscriminator(x => x.LocationQueueDiscriminator)
            .HasValue(LocationQueueDiscriminator.Quest);
        builder.HasOne(x => x.Quest)
            .WithOne(x => x.LocationQueue)
            .HasForeignKey<LocationQueueQuest>(x => x.QuestId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}