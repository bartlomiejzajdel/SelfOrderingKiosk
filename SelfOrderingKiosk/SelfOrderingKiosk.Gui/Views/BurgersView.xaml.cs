using SelfOrderingKiosk.Gui.Helpers;
using System.Windows;
using System.Windows.Controls;

namespace SelfOrderingKiosk.Gui.Views
{
    /// <summary>
    /// Interaction logic for BurgersView.xaml
    /// </summary>
    public partial class BurgersView : UserControl
    {
        public BurgersView()
        {
            InitializeComponent();
        }

        private void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            ActionHelper.AddToOrder(sender, e);
        }
    }
}
