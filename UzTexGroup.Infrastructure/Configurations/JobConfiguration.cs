using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Infrastructure.Configurations;

public class JobConfiguration : IEntityTypeConfiguration<Jobs>
{
    public void Configure(EntityTypeBuilder<Jobs> builder)
    {
        builder.ToTable(nameof(Jobs));

        builder.HasKey(job => job.Id);

        builder.Property(job => job.JobName)
            .HasMaxLength(70)
            .IsRequired(true);

        builder.Property(job => job.WorkTime)
            .HasMaxLength(50)
            .IsRequired(true);

        builder.Property(job => job.Salary)
            .IsRequired(true);

        builder.Property(job => job.Requirement)
            .HasMaxLength(300)
            .IsRequired(true);

        builder.HasOne(job => job.Factories)
            .WithMany(factory => factory.Jobs)
            .HasForeignKey(job => job.FactoryId);
    }
}
