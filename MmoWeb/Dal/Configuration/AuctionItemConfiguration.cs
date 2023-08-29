using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class AuctionItemConfiguration : IEntityTypeConfiguration<AuctionItem>
{
    public void Configure(EntityTypeBuilder<AuctionItem> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.AuctionOwner)
            .WithMany(x => x.AuctionItems)
            .HasForeignKey(x => x.AuctionOwnerId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x => x.SourceItemCustom)
            .WithOne(x => x.AuctionItem)
            .HasForeignKey<AuctionItem>(x=>x.SourceItemCustomId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}