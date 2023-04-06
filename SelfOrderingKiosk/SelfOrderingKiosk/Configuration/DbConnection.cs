namespace SelfOrderingKiosk.Configuration
{
    public static class DbConnection
    {
        public static string ConnectionString { get; private set; }

        public static void SetConnectionString(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
