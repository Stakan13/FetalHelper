using FetalHelper.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FetalHelper.Infrastructure.DatabaseAccess.Configurations;

public class RiskSnapshotConfiguration : IEntityTypeConfiguration<RiskSnapshot>
{
    public void Configure(EntityTypeBuilder<RiskSnapshot> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.CalculatedAt).IsRequired();
        builder.Property(x => x.HorizonMinutes).IsRequired();
        builder.Property(x => x.RiskScore).IsRequired();

        builder.Property(x => x.Metrics).HasConversion<string>();
    }
}