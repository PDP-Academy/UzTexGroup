using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UzTexGroup.Domain.Constants;
using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Infrastructure.Configurations;
public sealed class CompanyConfigurations : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.ToTable(TableNames.Company);

        builder.HasKey(company => company.Id);

        builder
            .Property(company => company.CompanyName)
            .HasMaxLength(100)
            .IsRequired(true);

        builder
            .Property(company => company.FoundedDate)
            .IsRequired(true);

        builder
            .HasOne(company => company.AboutCompany)
            .WithOne()
            .HasForeignKey<Company>(company => company.AboutCompanyId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

