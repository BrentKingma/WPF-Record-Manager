using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAddRecord_Click(object sender, RoutedEventArgs e)
        {
            AddRecordsWindow tempWindow = new AddRecordsWindow();
            tempWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                RecordModel model = Resources["recordModel"] as RecordModel;
                RecordController.Instance.SetModel(model);
                RecordController.Instance.AddDemos();
            }
            catch { }
            
        }

        private void BtnRemoveRecord_Click(object sender, RoutedEventArgs e)
        {
            RecordController.Instance.RemoveRecord(listName.SelectedIndex);
        }

        private void BtnEditRecord_Click(object sender, RoutedEventArgs e)
        {
            editNameTextBox.IsEnabled = true;
            editSurnameTextBox.IsEnabled = true;
            editAgeTextBox.IsEnabled = true;
            confirmEdit.IsEnabled = true;
        }

        private void listName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnRemoveRecord.IsEnabled = true;
            btnEditRecord.IsEnabled = true;
            RecordController.Instance.SetSelectedRecord(listName.SelectedIndex);
        }

        private void confirmEdit_Click(object sender, RoutedEventArgs e)
        {
            editNameTextBox.IsEnabled = false;
            editSurnameTextBox.IsEnabled = false;
            editAgeTextBox.IsEnabled = false;
            confirmEdit.IsEnabled = false;
        }
    }
}
