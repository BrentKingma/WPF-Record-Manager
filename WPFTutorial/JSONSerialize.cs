using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace WPFTutorial
{
    class JSONSerialize
    {
        private JSONSerialize() { }
        private static JSONSerialize instance;
        public static JSONSerialize Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new JSONSerialize();
                }
                return instance;
            }
        }

        public void Save(string fileName)
        {
            // Insert code to set properties and fields of the object.  
            XmlSerializer mySerializer = new (typeof(RecordModel));
            // To write to a file, create a StreamWriter object.  
            StreamWriter myWriter = new StreamWriter(fileName);
            mySerializer.Serialize(myWriter, RecordController.Instance.GetModel());
            myWriter.Close();
        }

        public void Load(string fileName)
        {
            if (File.Exists(fileName))
            {
                XmlSerializer serializer = new (typeof(RecordModel));
                using (Stream reader = new FileStream(fileName, FileMode.Open))
                {
                    RecordModel model = (RecordModel)serializer.Deserialize(reader);
                    RecordController.Instance.AddModelData(model);
                }
                
            }
        }
    }
}
