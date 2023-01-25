using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UzTexGroup.Domain.Constants;
using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Infrastructure.Configurations;

public class FactoryImagesConfiguration : IEntityTypeConfiguration<FactoryImages>
{
    public void Configure(EntityTypeBuilder<FactoryImages> builder)
    {
        builder.ToTable(TableNames.FactoryImages);

        builder.HasKey(factoryImages => factoryImages.Id);

        builder
            .Property(factoryImages => factoryImages.ImageUrl)
            .IsRequired(true);

        builder
            .HasOne(factoryImages => factoryImages.Factory)
            .WithMany(factory => factory.FactoryImages)
            .HasForeignKey(factoryImages => factoryImages.FactoryId);
    }
}
