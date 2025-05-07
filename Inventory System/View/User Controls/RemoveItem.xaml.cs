using System.Windows;
using System.Windows.Controls;

namespace Inventory_System.View.User_Controls
{

    public partial class RemoveItem : UserControl
    {
        MainWindow? mainWindow;

        public void FindMainWindow(MainWindow main)
        {
            mainWindow = main;
        }

        public RemoveItem()
        {
            InitializeComponent();
        }

        private void TryRemove(object sender, System.Windows.RoutedEventArgs e)
        {
            string input;
            input = tb_input.Text;

            if (TryParseInput(input) && mainWindow != null)
            {
                int value = ParsedInput(input);
                if (mainWindow.Items.ElementAtOrDefault(value) != null)
                {
                    ErrorPopup.Text = "";
                    mainWindow.Items.RemoveAt(value);
                    ConfirmPopup.Text = "Item successfully removed!";

                    for (int i = 0; i < mainWindow.Items.Count; i++)
                    {
                        mainWindow.Items[i].Index = i;
                    }
                }
                else
                {
                    ConfirmPopup.Text = "";
                    ErrorPopup.Text = $"Error: Your index value of {value} does not exist within the confines of the list.";
                }
            }
            else if (!TryParseInput(input) && mainWindow != null)
            {
                var checkItem = mainWindow.Items.FirstOrDefault(i => i.ItemName == input);
                if (checkItem != null)
                {
                    ErrorPopup.Text = "";
                    mainWindow.Items.Remove(checkItem);
                    ConfirmPopup.Text = "Item successfully removed!";

                    for (int i = 0; i < mainWindow.Items.Count; i++)
                    {
                        mainWindow.Items[i].Index = i;
                    }
                }
                else
                {
                    ConfirmPopup.Text = "";
                    ErrorPopup.Text = $"Error: The item: {input}, cannot be located inside the list.";
                }
            }


        }

        private bool TryParseInput(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int ParsedInput(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else { return 0; }
        }

        private void ClearAll(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to Clear All Items? (This is irreversible)", "Clear All?", 
                            MessageBoxButton.YesNo, MessageBoxImage.Question);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    if (mainWindow != null && mainWindow.Items != null)
                    {
                        mainWindow.Items.Clear();
                    }
                    ConfirmPopup.Text = "All Items are Cleared!";
                    break;
                default:
                    break;
            }
        }
    }
}
