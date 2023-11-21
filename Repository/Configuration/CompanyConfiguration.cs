using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    // Базовые миграции при создании БД
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasData(
            new Company
            {
                Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                Name = "Microsoft",
                Address = "USA Redmond",
                Country = "USA"
            },
            new Company
            {
                Id = new Guid("c8d4c053-49b6-733c-bc78-2d54a9991870"),
                Name = "Google",
                Address = "USA California",
                Country = "USA"
            }
        );
    }
}