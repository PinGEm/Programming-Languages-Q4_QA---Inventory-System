using System.Windows.Controls;

namespace Inventory_System.View.User_Controls
{

    public partial class AddItem : UserControl
    {
        MainWindow? mainWindow;
        string? input_text;
        
        public void FindMainWindow(MainWindow main)
        {
            mainWindow = main;
        }

        public AddItem()
        {
            InitializeComponent();
        }

        private void SubmitItem(object sender, System.Windows.RoutedEventArgs e)
        {
            string Input_text = itemName.Text;

            if (!string.IsNullOrEmpty(Input_text) && mainWindow != null)
            {
                // confirm
                confirmationText.Text = Input_text + " has been added to your inventory!";
                input_text = Input_text;

                InventoryList newItem = new InventoryList { Index = mainWindow.Items.Count, ItemName = input_text };
                mainWindow.Items.Add(newItem);
            }
            else
            {
                confirmationText.Text = "Please input a value into the box.";
                // input an error on the screen.
            }
        }
    }
}
