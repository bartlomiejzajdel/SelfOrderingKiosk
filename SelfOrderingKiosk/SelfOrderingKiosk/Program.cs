using SelfOrderingKiosk.Configuration;

namespace SelfOrderingKiosk
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConfiguration.LoadConfiguration();
        }
    }
}
