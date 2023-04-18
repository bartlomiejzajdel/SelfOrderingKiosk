using SelfOrderingKiosk.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SelfOrderingKiosk.Gui.Helpers
{
    public static class ActionHelper
    {
        public static void AddToOrder(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var product = (Product)button.DataContext;
            if (Order.OrderItems.Any(p => p.ProductId == product.Id))
            {
                Order.OrderItems.First(p => p.ProductId == product.Id).Quantity++;
            }
            else
            {
                Order.AddToOrder(new OrderItem(product));
            }
        }

    }
}
