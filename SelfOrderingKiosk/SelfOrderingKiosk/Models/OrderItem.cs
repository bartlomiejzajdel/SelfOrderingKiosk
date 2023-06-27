namespace SelfOrderingKiosk.Models
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; } = 1;
        public decimal Amount => Product.Price * Quantity;

        public OrderItem(Product product)
        {
            Product = product;
        }
    }
}
