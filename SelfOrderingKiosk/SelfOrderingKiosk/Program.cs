using SelfOrderingKiosk.Configuration;
using SelfOrderingKiosk.DataAccess;

namespace SelfOrderingKiosk
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConfiguration.LoadConfiguration();
            var dbservice = new DatabaseService();
            var products = dbservice.GetProductsList();
        }
    }
}
