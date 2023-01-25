using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UzTexGroup.Domain.Constants;
using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Infrastructure.Configurations;
public sealed class AboutCompaniesConfigurations : IEntityTypeConfiguration<AboutCompanies>
{
    public void Configure(EntityTypeBuilder<AboutCompanies> builder)
    {
        builder.ToTable(TableNames.AboutCompanies);

        builder.HasKey(aboutCompanies => aboutCompanies.Id);

        builder
            .Property(aboutCompanies => aboutCompanies.TitleUz)
            .HasMaxLength(100)
            .IsRequired(true);

        builder
            .Property(aboutCompanies => aboutCompanies.TitleUzC)
            .HasMaxLength(100)
            .IsRequired(false);

        builder
            .Property(aboutCompanies => aboutCompanies.TitleRu)
            .HasMaxLength(100)
            .IsRequired(false);

        builder
            .Property(aboutCompanies => aboutCompanies.TitleEn)
            .HasMaxLength(100)
            .IsRequired(false);

        builder
            .Property(aboutCompanies => aboutCompanies.ImageUrl)
            .HasMaxLength(100)
            .IsRequired(true);

        builder
            .Property(aboutCompanies => aboutCompanies.AboutCompanyUz)
            .HasMaxLength(100)
            .IsRequired(true);

        builder
            .Property(aboutCompanies => aboutCompanies.AboutCompanyUzC)
            .HasMaxLength(100)
            .IsRequired(false);

        builder
            .Property(aboutCompanies => aboutCompanies.AboutCompanyEn)
            .HasMaxLength(100)
            .IsRequired(false);

        builder
            .Property(aboutCompanies => aboutCompanies.AboutCompanyRu)
            .HasMaxLength(100)
            .IsRequired(false);

        builder.HasOne<Company>(aboutCompany => aboutCompany.Company)
            .WithOne(company => company.AboutCompany)
            .HasForeignKey<AboutCompanies>(aboutCompany => aboutCompany.CompanyId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}