using System.Windows;
using System.Windows.Controls;

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
                JSONSerialize.Instance.Load("testFile");
            }
            catch { }
            
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            JSONSerialize.Instance.Save("testFile");
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
