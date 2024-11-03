using ExpenseTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Infrastructure.Persistence.Configurations
{
    internal class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.ToTable(nameof(Notification));
            builder.HasKey(n => n.Id);

            builder
                .HasOne(n => n.User)
                .WithMany(u => u.Notifications)
                .HasForeignKey(n => n.UserId)
                .IsRequired();

            builder
                .Property(n => n.IsRead)
                .HasDefaultValue(false)
                .IsRequired();

            builder
                .Property(n => n.Title)
                .HasMaxLength(Constants.DEFAULT_STRING_LENGTH)
                .IsRequired();

            builder
                .Property(n => n.Body)
                .HasMaxLength(Constants.MAX_STRING_LENGTH)
                .IsRequired(false);

            builder
                .Property(n => n.RedirectUrl)
                .HasMaxLength(Constants.DEFAULT_STRING_LENGTH)
                .IsRequired();

            builder
                .HasQueryFilter(n => !n.IsRead);

            builder
                .Navigation(n => n.User)
                .AutoInclude();
        }
    }
}
