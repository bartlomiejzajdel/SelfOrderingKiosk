using SelfOrderingKiosk.Models;
using System.Collections.Generic;
using System.Linq;

namespace SelfOrderingKiosk.DataAccess
{
    public static class ProductsService
    {

        public static List<Product> ProductsList { get; set; } = DatabaseService.GetProductsList();
        public static List<Product> GetBurgers()
        {
            return ProductsList.Where(p => p.Type == 1).ToList();
        }

        public static List<Product> GetFries()
        {
            return ProductsList.Where(p => p.Type == 2).ToList();
        }

        public static List<Product> GetDrinks()
        {
            return ProductsList.Where(p => p.Type == 3).ToList();
        }
    }
}
