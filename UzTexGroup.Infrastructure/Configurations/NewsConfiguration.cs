using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UzTexGroup.Domain.Constants;
using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Infrastructure.Configurations;
public class NewsConfiguration : IEntityTypeConfiguration<News>
{
    public void Configure(EntityTypeBuilder<News> builder)
    {
        builder.ToTable(name:TableNames.Address);
        builder.HasKey(news => news.Id);

        builder.Property(news => news.Title)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(news => news.Body)
            .IsRequired();

        builder.Property(news => news.Date)
            .IsRequired();

        builder.HasMany(news => news.NewImages)
            .WithOne(newsImage => newsImage.News)
            .HasForeignKey(news => news.NewsId);
    }
}
