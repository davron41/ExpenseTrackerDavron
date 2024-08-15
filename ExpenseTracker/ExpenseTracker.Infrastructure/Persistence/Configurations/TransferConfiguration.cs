using ExpenseTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Infrastructure.Persistence.Configurations
{
    internal class TransferConfiguration : IEntityTypeConfiguration<Transfer>
    {
        public void Configure(EntityTypeBuilder<Transfer> builder)
        {
            builder.ToTable(nameof(Transfer));

            builder.HasOne(x => x.Category)
                .WithMany(c => c.Transfers)
                .HasForeignKey(x => x.CategoryId);

            builder.Property(x => x.Title)
                .HasMaxLength(Constants.DEFAULT_STRING_LENGTH)
                .HasColumnName("Name")
                .IsRequired();

            builder.Property(x => x.Description)
                .HasMaxLength(Constants.MAX_STRING_LENGTH)
                .IsRequired(false);

            builder.Property(x => x.Amount)
                .HasPrecision(13, 2)
                .IsRequired();
        }
    }
}
