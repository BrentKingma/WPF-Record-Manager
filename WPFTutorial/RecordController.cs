using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTutorial
{
    class RecordController
    {
        private RecordController() 
        {
            
        }
        private static RecordController controllerInstance;
        public static RecordController Instance
        {
            get
            {
                if(controllerInstance == null)
                {
                    controllerInstance = new RecordController();
                }
                return controllerInstance;
            }
        }
        
        public void SetModel(RecordModel recordModel)
        {
            this.recordModel = recordModel;
            this.recordModel.Records = new ObservableCollection<UserData>();
        }
        private RecordModel recordModel;

        public void AddRecord(string a_name, string a_surname, uint a_age)
        {
            recordModel.AddRecord(a_name, a_surname, a_age);
        }
        public void AddModelData(RecordModel model)
        {
            for(int i = 0; i < model.Records.Count; i ++)
            {
                recordModel.AddRecord(model.Records[i]);
            }
        }
        public void RemoveRecord(int idx)
        {
            recordModel.RemoveRecord(idx);
        }
        public void SetSelectedRecord(int idx)
        {
            recordModel.SetSelectedRecord(idx);
        }

        public void AddDemos()
        {
            recordModel.AddRecord("Brent", "Kingma", 23);
            recordModel.AddRecord("Chloe", "Kingma", 20);
            recordModel.AddRecord("Lachlan", "Brooks", 24);
        }
        public RecordModel GetModel()
        {
            recordModel.SelectedRecord = null;
            return recordModel;
        }

    }
}
