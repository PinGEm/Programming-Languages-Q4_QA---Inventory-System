using System.Windows.Controls;

namespace Inventory_System.View.User_Controls
{
    public partial class ViewInventory : UserControl
    {
        MainWindow mainWindow;

        public void FindMainWindow(MainWindow main)
        {
            mainWindow = main;
        }

        public ViewInventory()
        {
            InitializeComponent();
        }
    }
}
