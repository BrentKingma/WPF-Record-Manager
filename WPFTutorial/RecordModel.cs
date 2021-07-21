using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WPFTutorial
{
    public class RecordModel : INotifyPropertyChanged
    {
        private UserData selectedRecord;
        public UserData SelectedRecord
        {
            get
            {
                return selectedRecord;
            }
            set
            {
                selectedRecord = value;
                notifyChange("SelectedRecord");
            }
        }
        private ObservableCollection<UserData> obRecords;
        public ObservableCollection<UserData> Records
        {
            get
            {
                return obRecords;
            }
            set
            {
                obRecords = value;
                notifyChange("Records");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void notifyChange(string a_property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(a_property));
            }
        }

        public void AddRecord(string a_name, string a_surname, uint a_age)
        {
            obRecords.Add(new UserData(a_name, a_surname, a_age));
            notifyChange("Records");
        }
        public void AddRecord(UserData record)
        {
            obRecords.Add(record);
            notifyChange("Records");
        }
        public void RemoveRecord(int idx)
        {
            obRecords.RemoveAt(idx);
            notifyChange("Records");
        }
        public void SetSelectedRecord(int idx)
        {
            if(idx == -1)
            {
                SelectedRecord = null;
                return;
            }
            SelectedRecord = obRecords[idx];
        }
    }
}
