using Entities.Abstract;
using Entities.Discriminators;
using Entities.Entity.Messages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class MessageChannelConfiguration : IEntityTypeConfiguration<MessageChannel>
{
    public void Configure(EntityTypeBuilder<MessageChannel> builder)
    {
        builder.HasBaseType<MessageAbstract>()
            .HasDiscriminator(x => x.MessageDiscriminator)
            .HasValue(MessageDiscriminator.Channel);
        builder.HasOne(x => x.Channel)
            .WithMany(x => x.SentMessages)
            .HasForeignKey(x => x.ChannelId)
            .OnDelete(DeleteBehavior.SetNull);

    }
}