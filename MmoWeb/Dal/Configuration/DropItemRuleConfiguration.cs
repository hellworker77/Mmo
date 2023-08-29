using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class DropItemRuleConfiguration : IEntityTypeConfiguration<DropItemRule>
{
    public void Configure(EntityTypeBuilder<DropItemRule> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Item)
            .WithMany(x => x.DropItemRules)
            .HasForeignKey(x => x.ItemId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x=>x.Npc)
            .WithMany(x=>x.DropItemRules)
            .HasForeignKey(x=>x.NpcId)
            .OnDelete(DeleteBehavior.Cascade); 
    }
}