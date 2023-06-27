using SelfOrderingKiosk.Configuration;
using SelfOrderingKiosk.Gui.ViewModels;
using SelfOrderingKiosk.Models;
using System.Windows;
using System.Windows.Controls;

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
            UpdateCurrentAmmount();
            BurgersView_Clicked(this, new RoutedEventArgs());
            ClearBasketButton.IsEnabled = false;
            ViewOrderButton.IsEnabled = false;
        }

        private void BurgersView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new BurgersViewModel();
            GoToPaymentButton.Visibility = Visibility.Collapsed;
            ViewOrderButton.Visibility = Visibility.Visible;
        }

        private void FriesView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new FriesViewModel();
            GoToPaymentButton.Visibility = Visibility.Collapsed;
            ViewOrderButton.Visibility = Visibility.Visible;
        }

        private void DrinksView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new DrinksViewModel();
            GoToPaymentButton.Visibility = Visibility.Collapsed;
            ViewOrderButton.Visibility = Visibility.Visible;
        }

        private void OrderView_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new OrderViewModel();
            ViewOrderButton.Visibility = Visibility.Collapsed;
            GoToPaymentButton.Visibility = Visibility.Visible;
        }

        private void GoToPaymentButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new PaymentViewModel();
            MainDockPanel.Visibility = Visibility.Collapsed;
            SecondaryDockPanel.Visibility = Visibility.Visible;
        }

        public void UpdateCurrentAmmount()
        {
            TxtBlockCurrentAmmount.Text = Order.TotalAmount.ToString("c");
            TxtBlockCurrentAmmount.TextAlignment = TextAlignment.Center;
        }

        private void ClearBasketButton_Click(object sender, RoutedEventArgs e)
        {
            Order.ClearCurrentOrder();
            UpdateCurrentAmmount();
            ClearBasketButton.IsEnabled = false;
            ViewOrderButton.IsEnabled = false;
            var button = (Button)sender;
            if (button.DataContext.GetType() == typeof(OrderViewModel))
                BurgersView_Clicked(this, null);
        }
    }
}
