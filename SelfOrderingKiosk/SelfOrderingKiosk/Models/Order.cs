using System.Collections.Generic;
using System.Linq;

namespace SelfOrderingKiosk.Models
{
    public static class Order
    {
        public static List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public static decimal TotalAmount => OrderItems.Sum(p => p.Amount);


        public static void AddToOrder(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public static void ClearCurrentOrder()
        {
            OrderItems.Clear();
        }
    }
}
