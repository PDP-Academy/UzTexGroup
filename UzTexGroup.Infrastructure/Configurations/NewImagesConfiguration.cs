using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UzTexGroup.Domain.Constants;
using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Infrastructure.Configurations;
public sealed class NewImagesConfiguration : IEntityTypeConfiguration<NewImages>
{
    public void Configure(EntityTypeBuilder<NewImages> builder)
    {
        builder.ToTable(TableNames.NewImages);

        builder.HasKey(newImage => newImage.Id);

        builder
            .Property(newImage => newImage.ImageUrl)
            .HasMaxLength(256)
            .IsRequired(true);

        builder
            .HasOne(newImage => newImage.News)
            .WithMany(@new => @new.NewImages)
            .HasForeignKey(newImage => @newImage.NewsId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
