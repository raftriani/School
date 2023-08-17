using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Domain.Entities;

namespace School.Infra.Data.Mappings
{
    internal class SchoolRecordsMapping : IEntityTypeConfiguration<SchoolRecords>
    {
        public void Configure(EntityTypeBuilder<SchoolRecords> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired()
                .HasField("varchar(100)");

            builder.Property(s => s.Format)
                .IsRequired()
                .HasField("varchar(100)");
        }
    }
}
