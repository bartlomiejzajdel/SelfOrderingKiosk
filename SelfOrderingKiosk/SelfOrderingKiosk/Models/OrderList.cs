using System.Collections.Generic;

namespace SelfOrderingKiosk.Models
{
    public class OrderList
    {
        public List<OrderItem> OrderItems { get; set; } = Order.OrderItems;
    }
}
