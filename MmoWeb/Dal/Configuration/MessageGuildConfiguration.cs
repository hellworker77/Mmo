using Entities.Abstract;
using Entities.Discriminators;
using Entities.Entity.Messages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class MessageGuildConfiguration : IEntityTypeConfiguration<MessageGuild>
{
    public void Configure(EntityTypeBuilder<MessageGuild> builder)
    {
        builder.HasBaseType<MessageAbstract>()
            .HasDiscriminator(x => x.MessageDiscriminator)
            .HasValue(MessageDiscriminator.Guild);
        builder.HasOne(x => x.Guild)
            .WithMany(x => x.SentMessages)
            .HasForeignKey(x => x.GuildId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}