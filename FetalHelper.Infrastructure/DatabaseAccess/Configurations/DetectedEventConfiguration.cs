using FetalHelper.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FetalHelper.Infrastructure.DatabaseAccess.Configurations;

public class DetectedEventConfiguration : IEntityTypeConfiguration<DetectedEvent>
{
    public void Configure(EntityTypeBuilder<DetectedEvent> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Type).HasConversion<string>();
        
        builder.Property(x => x.StartAt).IsRequired();
        builder.Property(x => x.EndAt).IsRequired();
        builder.Property(x => x.Confidence).IsRequired();
    }
}