using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UzTexGroup.Domain.Constants;
using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Infrastructure.Configurations;
public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable(TableNames.Address);

        builder.HasKey(address => address.Id);

        builder.Property(address => address.Country)
            .IsRequired(true)
            .HasMaxLength(50);

         builder.Property(address => address.Region)
            .IsRequired(true)
            .HasMaxLength(50);

         builder.Property(address => address.District)
            .IsRequired(false)
            .HasMaxLength(50);

         builder.Property(address => address.Street)
            .IsRequired(false)
            .HasMaxLength(50);

         builder.Property(address => address.PostalCode)
           .IsRequired(false);
    }
}
