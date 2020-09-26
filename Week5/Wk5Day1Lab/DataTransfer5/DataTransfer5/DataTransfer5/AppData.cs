using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;
using Xamarin.Forms.Internals;

namespace DataTransfer5
{
    public class AppData
    {
        public AppData()
        {
            InfoCollection = new ObservableCollection<InformationViewModel>();
            CurrentInfoIndex = -1;
        }

        public ObservableCollection<InformationViewModel> InfoCollection { private set; get; }

        [XmlIgnore]
        public InformationViewModel CurrentInfo { set; get; }

        public int CurrentInfoIndex { set; get; }

        public string Serialize()
        {
            if (CurrentInfo != null)
            {
                CurrentInfoIndex = InfoCollection.IndexOf(CurrentInfo);
            }
            XmlSerializer serializer = new XmlSerializer(typeof(AppData));
            using (StringWriter stringWrite = new StringWriter())
            {
                serializer.Serialize(stringWrite, this);
                return stringWrite.GetStringBuilder().ToString();
            }
        }
        
        public static AppData Deserialize(string strAppData)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AppData));
            using (StringReader stringReader = new StringReader(strAppData))
            {
                AppData appData = (AppData)serializer.Deserialize(stringReader);

                if (appData.CurrentInfoIndex != -1)
                {
                    appData.CurrentInfo = appData.InfoCollection[appData.CurrentInfoIndex];
                }
                return appData;
            }
        }
    }
}
