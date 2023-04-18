using System.Collections.Generic;

namespace SelfOrderingKiosk.Models
{
    public static class Order
    {
        public static List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public static void AddToOrder(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }
    }
}
