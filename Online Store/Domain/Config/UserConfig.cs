using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Online_Store.Domain.Data;

namespace Online_Store.Domain.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        { 
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Orders).WithOne(x => x.User).HasForeignKey(x => x.UserId);
        }
    }
}
