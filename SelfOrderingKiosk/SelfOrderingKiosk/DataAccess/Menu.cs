using SelfOrderingKiosk.Configuration;
using SelfOrderingKiosk.Models;
using System.Collections.Generic;

namespace SelfOrderingKiosk.DataAccess
{
    public class Menu
    {
        public Menu()
        {
            DbConfiguration.LoadConfiguration();
        }
        public List<Product> BurgersList { get; set; } = ProductsService.GetBurgers();
        public List<Product> FriesList { get; set; } = ProductsService.GetFries();
        public List<Product> DrinksList { get; set; } = ProductsService.GetDrinks();
    }
}
