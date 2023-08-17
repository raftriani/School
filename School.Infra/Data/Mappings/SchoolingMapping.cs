using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;

namespace School.Infra.Data.Mappings
{
    internal class SchoolingMapping : IEntityTypeConfiguration<Schooling>
    {
        public void Configure(EntityTypeBuilder<Schooling> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(s => s.Description)
                .IsRequired()
                .HasField("varchar(100)");

            builder.HasMany(s => s.Users)
                    .WithOne(u => u.Schooling)
                    .HasForeignKey(s => s.SchoolingId);
        }
    }
}
