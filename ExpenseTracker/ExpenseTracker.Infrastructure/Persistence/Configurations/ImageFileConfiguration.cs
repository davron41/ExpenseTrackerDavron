using ExpenseTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Infrastructure.Persistence.Configurations;

public class ImageFileConfiguration : IEntityTypeConfiguration<Domain.Entities.ImageFile>
{
    public void Configure(EntityTypeBuilder<ImageFile> builder)
    {
        builder.ToTable(nameof(ImageFile));

        builder.HasOne(x => x.Transfer)
            .WithMany(t => t.Images)
            .HasForeignKey(x => x.TransferId)
            .IsRequired();

        builder.Property(x => x.Name)
                .HasMaxLength(Constants.DEFAULT_STRING_LENGTH)
                .IsRequired();
    }
}
