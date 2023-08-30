using System.Security.Cryptography.X509Certificates;
using Entities.Abstract;
using Entities.Discriminators;
using Entities.Entity.LocationQueues;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class LocationQueueNpcConfiguration : IEntityTypeConfiguration<LocationQueueNpc>
{
    public void Configure(EntityTypeBuilder<LocationQueueNpc> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasBaseType<LocationQueueAbstract>()
            .HasDiscriminator(x => x.LocationQueueDiscriminator)
            .HasValue(LocationQueueDiscriminator.Npc);
        builder.HasOne(x => x.Npc)
            .WithOne(x => x.LocationQueue)
            .HasForeignKey<LocationQueueNpc>(x=>x.NpcId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}