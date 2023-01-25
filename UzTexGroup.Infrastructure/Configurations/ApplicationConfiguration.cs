    using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UzTexGroup.Domain.Constants;
using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Infrastructure.Configurations;
public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
{
    public void Configure(EntityTypeBuilder<Application> builder)
    {
        builder.ToTable(TableNames.Application);

        builder.HasKey(application => application.Id);

        builder
            .Property(app => app.CandidateFullName)
            .HasMaxLength(100)
            .IsRequired(true);

        builder
            .Property(app => app.TellNumber)
            .HasMaxLength(30)
            .IsRequired(true);

        builder
            .Property(app => app.Email)
            .HasMaxLength(255)
            .IsRequired(true);

        builder
            .Property(app => app.CandidateMessage)
            .HasMaxLength(500)
            .IsRequired(true);

        builder
            .HasOne(app => app.Address)
            .WithOne()
            .HasForeignKey<Application>(app => app.AddressId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasOne(app => app.Job)
            .WithMany(job => job.Applications)
            .HasForeignKey(app => app.JobId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
