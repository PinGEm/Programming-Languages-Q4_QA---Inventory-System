using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;

namespace Inventory_System
{

    public class InventoryList : INotifyPropertyChanged
    {
        private int index;
        private string name = "";

        public required int Index
        {
            get => index;
            set
            {
                if (index != value)
                {
                    index = value;
                    OnPropertyChanged();
                }
            }
        }

        public required string ItemName
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public partial class MainWindow : Window
    {
        public ObservableCollection<InventoryList> Items { get; set; } = new();


        public MainWindow()
        {
            InitializeComponent();

            var MenuBar = this.menuBar;
            var AddItem = this.addItem;
            var ViewInventory = this.viewInventory;
            var RemoveItem = this.removeItem;

            menuBar.FindMainWindow(this);
            addItem.FindMainWindow(this);
            viewInventory.FindMainWindow(this);
            removeItem.FindMainWindow(this);

            removeItem.DataContext = this;
            viewInventory.DataContext = this;
        }
    }
}