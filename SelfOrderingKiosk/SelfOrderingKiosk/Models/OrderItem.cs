namespace SelfOrderingKiosk.Models
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; } = 1;

        public OrderItem(Product product)
        {
            Product = product;
        }
    }
}
