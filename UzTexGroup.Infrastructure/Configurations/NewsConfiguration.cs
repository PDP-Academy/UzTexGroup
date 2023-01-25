using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UzTexGroup.Domain.Constants;
using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Infrastructure.Configurations;
public sealed class NewsConfiguration : IEntityTypeConfiguration<News>
{
    public void Configure(EntityTypeBuilder<News> builder)
    {
        builder.ToTable(TableNames.News);

        builder.HasKey(@news => @news.Id);

        builder
            .Property(news => news.TitleUz)
            .IsRequired(true)
            .HasMaxLength(150);

        builder
            .Property(news => news.TitleUzC)
            .IsRequired(false)
            .HasMaxLength(150);

        builder
            .Property(news => news.TitleEn)
            .IsRequired(false)
            .HasMaxLength(150);

        builder
            .Property(news => news.TitleRu)
            .IsRequired(false)
            .HasMaxLength(150);

        builder
            .Property(news => news.BodyUz)
            .IsRequired(true)
            .HasMaxLength(150);

        builder
            .Property(news => news.BodyUzC)
            .IsRequired(false)
            .HasMaxLength(150);

        builder
            .Property(news => news.BodyEn)
            .IsRequired(false)
            .HasMaxLength(150);

        builder
            .Property(news => news.BodyRu)
            .IsRequired(false)
            .HasMaxLength(150);

        builder
            .Property(news => news.Date)
            .IsRequired(true);
    }
}
