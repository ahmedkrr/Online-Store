using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Online_Store.Domain.Data;

namespace Online_Store.Domain.Config
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.OrderId);
            builder.HasMany(x => x.ProudctOrders).WithOne(x => x.Order).HasForeignKey(x => x.OrdertId);


        }
    }
}
