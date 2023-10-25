using Entities.Abstract;
using Entities.Discriminators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Configuration;

public class QuestCompleteConditionAbstractConfiguration : IEntityTypeConfiguration<QuestCompleteConditionAbstract>
{
    public void Configure(EntityTypeBuilder<QuestCompleteConditionAbstract> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasDiscriminator(x => x.CompleteConditionDiscriminator)
            .HasValue(QuestCompleteConditionDiscriminator.Abstract);
        builder.HasOne(x => x.TargetQuest)
            .WithMany(x => x.QuestCompleteConditions)
            .HasForeignKey(x => x.TargetQuestId)
            .OnDelete(DeleteBehavior.Cascade);

    }
}