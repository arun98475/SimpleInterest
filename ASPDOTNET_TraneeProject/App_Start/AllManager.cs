using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTrials.App_Start
{
    public class AllSettings
    {
        public string DefaultText1 { get; set; }
        public string DefaultText2 { get; set; }
        public string DefaultHeader { get; set; }
        public string DefaultFooter { get; set; }
        public int PageRefreshCounter { get; set; }

        public int VisitorNumber { get; set; }
    }

    public class AllManager
    {
        
        public AllManager()
        {
            //constructor
        }
        public static AllSettings LoadSettings()
        {
            AllSettings Setting = new AllSettings();
            try {
                var fileName = HttpContext.Current.Server.MapPath("/App_Data/AllSettings.xml");
                System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(AllSettings));
                System.IO.StreamReader file = new System.IO.StreamReader(fileName);
                Setting = (AllSettings)reader.Deserialize(file);
                file.Close();
                return Setting;
            }
            catch (Exception) 
            {
                return Setting;
            }
            
        }

        public static void SaveSettings(AllSettings ObjSettings)
        {
            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(AllSettings));

            var fileName = HttpContext.Current.Server.MapPath("/App_Data/AllSettings.xml");
            System.IO.FileStream file = System.IO.File.Create(fileName);

            writer.Serialize(file, ObjSettings);
            file.Close();
        }
    }
}