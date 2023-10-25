using Entities.Abstract;
using Entities.Discriminators;
using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class MessageAbstractConfiguration : IEntityTypeConfiguration<MessageAbstract>
{
    public void Configure(EntityTypeBuilder<MessageAbstract> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x=>x.Sender)
            .WithMany(x=>x.SentMessages)
            .HasForeignKey(x=>x.SenderId)
            .OnDelete(DeleteBehavior.SetNull);
        builder.HasDiscriminator(x => x.MessageDiscriminator)
            .HasValue(MessageDiscriminator.Abstract);
    }
}