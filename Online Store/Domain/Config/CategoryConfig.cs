using Microsoft.EntityFrameworkCore;
using Online_Store.Domain.Data;

namespace Online_Store.Domain.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(b => b.CategoryId);
            builder.HasMany(b => b.SubCategories).WithOne(b => b.Category).HasForeignKey(b => b.SubCategoryId);
            
        }
    }
}
