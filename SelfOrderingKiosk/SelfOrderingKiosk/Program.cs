using SelfOrderingKiosk.Configuration;
using SelfOrderingKiosk.DataAccess;

namespace SelfOrderingKiosk
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConfiguration.LoadConfiguration();
            var products = DatabaseService.GetProductsList();
        }
    }
}
