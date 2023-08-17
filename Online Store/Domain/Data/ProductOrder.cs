namespace Online_Store.Domain.Data
{
    public class ProductOrder
    {
        public int POId { get; set; }
        public Order Order { get; set; } = null!;
        public int OrdertId { get; set; }
        public Product Product { get; set; } = null!;
        public int ProductId { get; set; }

    }
}
