using Microsoft.EntityFrameworkCore;
using Online_Store.Domain.Data;

namespace Online_Store.Domain.Config
{
    public class SubCategoryConfig : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasKey(b => b.SubCategoryId);
            


        }
    }
}
