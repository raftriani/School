using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Domain.Entities;

namespace School.Infra.Data.Mappings
{
    internal class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                .IsRequired()
                .HasField("varchar(100)");

            builder.Property(u => u.Surname)
                .IsRequired()
                .HasField("varchar(100)");

            builder.Property(u => u.Email)
                .IsRequired()
                .HasField("varchar(200)");

            builder.Property(u => u.BirthDate)
               .IsRequired()
               .HasField("datetime");

            builder.HasOne(u => u.SchoolRecords)
                .WithOne(s => s.User)
                .HasForeignKey<User>(u => u.SchoolRecordsId);
        }
    }
}
