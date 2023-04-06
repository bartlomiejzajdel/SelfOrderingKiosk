using System.Configuration;

namespace SelfOrderingKiosk.Configuration
{
    public static class DbConfiguration
    {
        public static void LoadConfiguration()
        {
            DbConnection.SetConnectionString(ConfigurationManager.ConnectionStrings["SelfOrderingKioskConnectionString"].ConnectionString);
          }
    }
}
