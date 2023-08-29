using Entities.Abstract;
using Entities.Discriminators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class LocationQueueAbstractConfiguration : IEntityTypeConfiguration<LocationQueueAbstract>
{
    public void Configure(EntityTypeBuilder<LocationQueueAbstract> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasDiscriminator(x => x.LocationQueueDiscriminator)
            .HasValue(LocationQueueDiscriminator.Abstract);
        builder.HasOne(x => x.Location)
            .WithMany(x => x.LocationQueues)
            .HasForeignKey(x => x.LocationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}