using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UzTexGroup.Domain.Constants;
using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Infrastructure.Configurations;

public class FactoryConfiguration : IEntityTypeConfiguration<Factory>
{
    public void Configure(EntityTypeBuilder<Factory> builder)
    {
        builder.ToTable(TableNames.Factories);

        builder.HasKey(factory => factory.Id);

        builder
            .Property(factory => factory.Name)
            .HasMaxLength(50)
            .IsRequired(true);


        builder
            .HasOne(factory => factory.Address)
            .WithOne()
            .HasForeignKey<Factory>(factory => factory.AddressId)
            .OnDelete(DeleteBehavior.Cascade);


        builder
            .HasOne(factory => factory.Company)
            .WithMany(company => company.Factories)
            .HasForeignKey(factory => factory.CompanyId);

    }
}
