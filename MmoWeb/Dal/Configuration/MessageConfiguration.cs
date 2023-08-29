using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class MessageConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Channel)
            .WithMany(x => x.Messages)
            .HasForeignKey(x => x.Id)
            .OnDelete(DeleteBehavior.SetNull);
        builder.HasOne(x=>x.Sender)
            .WithMany(x=>x.Messages)
            .HasForeignKey(x=>x.SenderId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}