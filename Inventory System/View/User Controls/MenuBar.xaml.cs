using System.Windows;
using System.Windows.Controls;

namespace Inventory_System.View.User_Controls
{
    public partial class MenuBar : UserControl
    {
        private MainWindow? mainWindow;

        public MenuBar()
        {
            InitializeComponent();
        }

        private void Exit_Application(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to Exit the Application?", "Exit App", MessageBoxButton.YesNo, MessageBoxImage.Stop);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    Application.Current.Shutdown();
                    break;
                default:
                    break;
            }
        }

        public void FindMainWindow(MainWindow main)
        {
            mainWindow = main;
        }

        private void Add_Item(object sender, RoutedEventArgs e)
        {
            if (mainWindow == null)
            {
                return;
            }

            Panel.SetZIndex(mainWindow.addItem, 1);
            Panel.SetZIndex(mainWindow.removeItem, -1);
            Panel.SetZIndex(mainWindow.viewInventory, -1);

            // Change the border
            this.PurpBorder.SetValue(Grid.ColumnProperty, 2);
            this.BlackBorder.SetValue(Grid.ColumnProperty, 2);
            showText.Text = "Add to Inventory System";
        }

        private void View_Inventory(object sender, RoutedEventArgs e)
        {
            if (mainWindow == null)
            {
                return;
            }

            Panel.SetZIndex(mainWindow.addItem, -1);
            Panel.SetZIndex(mainWindow.removeItem, -1);
            Panel.SetZIndex(mainWindow.viewInventory, 1);

            // Change the border
            this.PurpBorder.SetValue(Grid.ColumnProperty, 1);
            this.BlackBorder.SetValue(Grid.ColumnProperty, 1);
            showText.Text = "View Inventory System";
        }

        private void Remove_Item(object sender, RoutedEventArgs e)
        {
            if (mainWindow == null)
            {
                return;
            }

            Panel.SetZIndex(mainWindow.addItem, -1);
            Panel.SetZIndex(mainWindow.removeItem, 1);
            Panel.SetZIndex(mainWindow.viewInventory, -1);

            // Change the border
            this.PurpBorder.SetValue(Grid.ColumnProperty, 3);
            this.BlackBorder.SetValue(Grid.ColumnProperty, 3);
            showText.Text = "Remove in Inventory System";
        }
    }
}
