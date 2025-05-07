using System.Windows;

namespace Inventory_System
{
    public partial class MainWindow : Window
    {
        public List<string> items = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            var MenuBar = this.menuBar;
            var AddItem = this.addItem;
            var ViewInventory = this.viewInventory;

            menuBar.FindMainWindow(this);
            addItem.FindMainWindow(this);
            viewInventory.FindMainWindow(this);
        }
    }
}