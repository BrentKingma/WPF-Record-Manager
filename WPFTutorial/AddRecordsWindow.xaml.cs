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
using System.Windows.Shapes;

namespace WPFTutorial
{
    /// <summary>
    /// Interaction logic for AddRecordsWindow.xaml
    /// </summary>
    public partial class AddRecordsWindow : Window
    {
        public AddRecordsWindow()
        {
            InitializeComponent();
        }

        private void BtnAddRecord_Click(object sender, RoutedEventArgs e)
        {
            RecordController.Instance.AddRecord(recordName.Text, recordSurname.Text, uint.Parse(recordAge.Text, System.Globalization.NumberStyles.Integer));
            recordName.Clear();
            recordSurname.Clear();
            recordAge.Clear();
        }
    }
}
