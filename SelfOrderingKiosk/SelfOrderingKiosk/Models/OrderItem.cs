namespace SelfOrderingKiosk.Models
{
    public class OrderItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; } = 1;

        public OrderItem(Product product)
        {
            ProductId = product.Id;

        }
    }
}
