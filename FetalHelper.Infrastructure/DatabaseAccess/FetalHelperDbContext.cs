using Microsoft.EntityFrameworkCore;
using FetalHelper.Core.Entities;
using FetalHelper.Infrastructure.DatabaseAccess.Configurations;

namespace FetalHelper.Infrastructure.DatabaseAccess;

public class FetalHelperDbContext : DbContext
{
    public DbSet<MonitoringSession> MonitoringSessions { get; set; }
    public DbSet<DetectedEvent> DetectedEvents { get; set; }
    public DbSet<RiskSnapshot> RiskSnapshots { get; set; }
    public DbSet<Annotation> Annotations { get; set; }
    
    public FetalHelperDbContext(DbContextOptions<FetalHelperDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new MonitoringSessionConfiguration());
        modelBuilder.ApplyConfiguration(new DetectedEventConfiguration());
        modelBuilder.ApplyConfiguration(new RiskSnapshotConfiguration());
        modelBuilder.ApplyConfiguration(new AnnotationConfiguration());
    }
 }