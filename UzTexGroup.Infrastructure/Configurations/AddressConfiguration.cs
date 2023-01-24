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
            .IsRequired()
            .HasMaxLength(50);

         builder.Property(address => address.Region)
            .IsRequired()
            .HasMaxLength(50);

         builder.Property(address => address.District)
            .IsRequired()
            .HasMaxLength(50);

         builder.Property(address => address.Street)
            .IsRequired()
            .HasMaxLength(50);

         builder.Property(address => address.PostalCode)
           .IsRequired();
    }
}
