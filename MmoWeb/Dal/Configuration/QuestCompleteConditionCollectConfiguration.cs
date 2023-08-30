using Entities.Abstract;
using Entities.Discriminators;
using Entities.Entity.QuestCompleteConditions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class QuestCompleteConditionCollectConfiguration : IEntityTypeConfiguration<QuestCompleteConditionCollect>
{
    public void Configure(EntityTypeBuilder<QuestCompleteConditionCollect> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasBaseType<QuestCompleteConditionAbstract>()
            .HasDiscriminator(x => x.CompleteConditionDiscriminator)
            .HasValue(QuestCompleteConditionDiscriminator.Collect);
        builder.HasOne(x => x.TargetItem)
            .WithMany(x => x.QuestCompleteConditionsCollect)
            .HasForeignKey(x => x.TargetItemId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}