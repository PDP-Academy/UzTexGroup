using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UzTexGroup.Domain.Constants;
using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Infrastructure.Configurations;
public sealed class NewImagesConfiguration : IEntityTypeConfiguration<NewsImages>
{
    public void Configure(EntityTypeBuilder<NewsImages> builder)
    {
        builder.ToTable(TableNames.NewImages);

        builder.HasKey(newImage => newImage.Id);

        builder
            .Property(newImage => newImage.ImageUrl)
            .HasMaxLength(200)
            .IsRequired(true);

        builder
            .HasOne(newImage => newImage.News)
            .WithMany(@new => @new.NewImages)
            .HasForeignKey(newImage => @newImage.NewsId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
