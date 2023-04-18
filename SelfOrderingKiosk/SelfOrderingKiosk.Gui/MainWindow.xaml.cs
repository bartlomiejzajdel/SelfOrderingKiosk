using SelfOrderingKiosk.Configuration;
using SelfOrderingKiosk.Gui.ViewModels;
using SelfOrderingKiosk.Models;
using System.Windows;

namespace SelfOrderingKiosk.Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DbConfiguration.LoadConfiguration();
            InitializeComponent();
            WindowState = WindowState.Maximized;
            BurgersView_Clicked(this, new RoutedEventArgs());
            
        }

        private void BurgersView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new BurgersViewModel();
        }

        private void FriesView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new FriesViewModel();
        }

        private void DrinksView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new DrinksViewModel();
        }

        private void OrderView_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new OrderViewModel();
        }
    }
}
