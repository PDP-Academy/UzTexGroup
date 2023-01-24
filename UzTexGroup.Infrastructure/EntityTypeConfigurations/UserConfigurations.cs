using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UzTexGroup.Domain.Constants;
using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Infrastructure.EntityTypeConfigurations;
public sealed class UserConfigurations : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable(TableNames.Users);

        builder.HasKey(user => user.Id);

        builder
            .Property(user => user.FullName)
            .HasMaxLength(50)
            .IsRequired(true);

        builder
            .Property(user => user.Email)
            .HasMaxLength(255)
            .IsRequired(true);

        builder
            .Property(user => user.PasswordHash)
            .HasMaxLength(255)
            .IsRequired(true);

        builder
            .Property(user => user.Salt)
            .HasMaxLength(100)
            .IsRequired(true);
    }
}
