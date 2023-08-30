using Entities.Abstract;
using Entities.Discriminators;
using Entities.Entity.QuestCompleteConditions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class QuestCompleteConditionKillConfiguration : IEntityTypeConfiguration<QuestCompleteConditionKill>
{
    public void Configure(EntityTypeBuilder<QuestCompleteConditionKill> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasBaseType<QuestCompleteConditionAbstract>()
            .HasDiscriminator(x => x.CompleteConditionDiscriminator)
            .HasValue(QuestCompleteConditionDiscriminator.Kill);
        builder.HasOne(x => x.TargetNpc)
            .WithMany(x => x.QuestCompleteConditionsKill)
            .HasForeignKey(x => x.TargetNpcId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}