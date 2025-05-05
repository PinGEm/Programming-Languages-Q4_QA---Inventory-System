using System.Windows;

namespace Inventory_System
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var MenuBar = this.menuBar;

            menuBar.FindMainWindow(this);
        }
    }
}