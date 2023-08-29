using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class ItemCustomConfiguration : IEntityTypeConfiguration<ItemCustom>
{
    public void Configure(EntityTypeBuilder<ItemCustom> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Owner)
            .WithMany(x => x.CustomItems)
            .HasForeignKey(x => x.OwnerId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x => x.AuctionItem)
            .WithOne(x => x.SourceItemCustom)
            .HasForeignKey<AuctionItem>(x => x.SourceItemCustomId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x => x.SourceItem)
            .WithMany(x => x.ItemCustoms)
            .HasForeignKey(x => x.SourceItemId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}