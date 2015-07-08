using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APSCS.TestFramework
{
    public class Settings
    {
        public static string GetLastAPSPackage()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            string result = "";
            try { result = config.AppSettings.Settings["lastAPSPackage"].Value; }
            catch{}
            return result; 
        }
        public static void SetLastAPSPackage(string lastAPSPackage)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Add("lastAPSPackage", lastAPSPackage);
            config.Save(ConfigurationSaveMode.Minimal);
        }

        public static string GetEndpointSHUrl()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            string result = "";
            try { result = config.AppSettings.Settings["endpointURL"].Value; }
            catch{}
            return result; 
        }


    }

}
