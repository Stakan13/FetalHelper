using FetalHelper.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FetalHelper.Infrastructure.DatabaseAccess.Configurations;

public class AnnotationConfiguration :  IEntityTypeConfiguration<Annotation>
{
    public void Configure(EntityTypeBuilder<Annotation> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Type).HasConversion<string>();
        builder.Property(x => x.Author).HasConversion<string>();
        
        builder.Property(x => x.Time).IsRequired();
        builder.Property(x => x.Text).IsRequired();
    }
}