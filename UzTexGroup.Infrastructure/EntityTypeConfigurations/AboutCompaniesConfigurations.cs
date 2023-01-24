using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UzTexGroup.Domain.Constants;
using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Infrastructure.EntityTypeConfigurations;
public sealed class AboutCompaniesConfigurations : IEntityTypeConfiguration<AboutCompanies>
{
    public void Configure(EntityTypeBuilder<AboutCompanies> builder)
    {
        builder.ToTable(TableNames.AboutCompanies);

        builder.HasKey(aboutCompanies => aboutCompanies.Id);

        builder
            .Property(aboutCompanies => aboutCompanies.TitleUz)
            .HasMaxLength(70)
            .IsRequired(true);

        builder
            .Property(aboutCompanies => aboutCompanies.image_Url)
            .HasMaxLength(255)
            .IsRequired(true);

        builder
            .Property(aboutCompanies => aboutCompanies.AboutCompanyUz)
            .HasMaxLength(500)
            .IsRequired(true);
    }
}
