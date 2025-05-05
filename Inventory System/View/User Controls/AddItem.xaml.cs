using System.Windows.Controls;

namespace Inventory_System.View.User_Controls
{

    public partial class AddItem : UserControl
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void SubmitItem(object sender, System.Windows.RoutedEventArgs e)
        {
            string input_text = itemName.Text;

            if (!string.IsNullOrEmpty(input_text))
            {
                // do something
                confirmationText.Text = input_text + " has been added to your inventory!";
            }
            else
            {
                confirmationText.Text = "Please input a value into the box.";
                // input an error on the screen.
            }
        }
    }
}
