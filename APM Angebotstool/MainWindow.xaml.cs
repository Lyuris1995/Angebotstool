using System.Windows;
using System.Windows.Controls;

namespace APM_Angebotstool
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProductGroupComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)ProductGroupComboBox.SelectedItem;
            string selectedGroup = selectedItem.Content.ToString();

            // Hier können Sie die Produkte für die ausgewählte Produktgruppe festlegen
            // Beispiel:
            ProductComboBox.Items.Clear();
            if (selectedGroup == "Produktgruppe 1")
            {
                ProductComboBox.Items.Add("Produkt 1.1");
                ProductComboBox.Items.Add("Produkt 1.2");
                ProductComboBox.Items.Add("Produkt 1.3");
            }
            else if (selectedGroup == "Produktgruppe 2")
            {
                ProductComboBox.Items.Add("Produkt 2.1");
                ProductComboBox.Items.Add("Produkt 2.2");
                ProductComboBox.Items.Add("Produkt 2.3");
            }
            else if (selectedGroup == "Produktgruppe 3")
            {
                ProductComboBox.Items.Add("Produkt 3.1");
                ProductComboBox.Items.Add("Produkt 3.2");
                ProductComboBox.Items.Add("Produkt 3.3");
            }

            //ProductSelectionPanel.Visibility = Visibility.Visible;
        }
    }
}