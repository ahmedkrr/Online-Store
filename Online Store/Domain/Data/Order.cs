namespace Online_Store.Domain.Data
{
    public class Order
    {
        public int OrderId { get; set; }
        public User User { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public List<ProductOrder> ProudctOrders { get; set; } = null!;

    }
}
