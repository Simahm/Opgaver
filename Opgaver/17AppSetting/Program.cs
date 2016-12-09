using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17AppSetting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetAppSetting("ip", "test"));

            Console.WriteLine(GetAppSettingGeneric("maxrecords", 80));

            Console.ReadKey();
        }

        static string GetAppSetting(string key, string defaultValue)
        {
            string value = System.Configuration.ConfigurationManager.AppSettings[key];
            if (value == null)
                return defaultValue;

            return value;
        }

        static T GetAppSettingGeneric<T>(string key, T defaultValue)
        {
            string value = System.Configuration.ConfigurationManager.AppSettings[key];
            if (value == null)
                return defaultValue;

            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}
