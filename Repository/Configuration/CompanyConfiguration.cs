using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company{
                    _id= Convert.ToString(new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")),
                    name="SamDev Solutions",
                    address="Some place near neptune",
                    employeeCount=1451
                },
                new Company{
                    _id= Convert.ToString(new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")),
                    name="Radio Shack",
                    address="Some place mysterious place near the outer galaxy",
                    employeeCount=123456
                }
            );
        }
    }
}