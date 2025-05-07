using System.Windows.Controls;

namespace Inventory_System.View.User_Controls
{

    public partial class AddItem : UserControl
    {
        MainWindow mainWindow;
        string input_text;
        
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

            if (!string.IsNullOrEmpty(Input_text))
            {
                int index = -1;

                // do something
                confirmationText.Text = Input_text + " has been added to your inventory!";
                input_text = Input_text;
                mainWindow.items.Add(input_text);

                //TEMPORARY
                for (int i = -1; i < mainWindow.items.Count; i++)
                {
                    index = i;
                }

                mainWindow.viewInventory.index_IL.Items.Add(index);
                mainWindow.viewInventory.name_IL.Items.Add(mainWindow.items[index]);
            }
            else
            {
                confirmationText.Text = "Please input a value into the box.";
                // input an error on the screen.
            }
        }
    }
}
