using FetalHelper.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FetalHelper.Infrastructure.DatabaseAccess.Configurations;

public class MonitoringSessionConfiguration : IEntityTypeConfiguration<MonitoringSession>
{
    public void Configure(EntityTypeBuilder<MonitoringSession> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Mode).HasConversion<string>();
        builder.Property(x => x.Status).HasConversion<string>();
        
        builder.Property(x => x.StartTime).IsRequired();
        builder.Property(x => x.EndTime).IsRequired();
        builder.Property(x => x.GestationalAgeWeeks).IsRequired();
        builder.Property(x => x.SampleRateHz).IsRequired();
        builder.Property(x => x.PatientRef).IsRequired();
        
        builder.HasIndex(x => x.PatientRef);
        builder.HasIndex(x => x.DeviceId);
        
        builder.HasMany(ms => ms.Snapshots)
            .WithOne()
            .HasForeignKey(x => x.SessionId);
        builder.HasMany(ms => ms.Events)
            .WithOne()
            .HasForeignKey(x => x.SessionId);
        builder.HasMany(ms => ms.Annotations)
            .WithOne()
            .HasForeignKey(x => x.SessionId);
        
    }
}