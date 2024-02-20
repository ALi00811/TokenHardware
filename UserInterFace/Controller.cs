using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace UserInterFace
{
    public static class Controller
    {
        public static string getHid()
        {
            string ProcessorId = string.Empty;
            ManagementClass mClass = new ManagementClass("win32_Processor");
            ManagementObjectCollection mCollection = mClass.GetInstances();

            foreach (ManagementObject mObj in mCollection)
            {
                ProcessorId = mObj.Properties["ProcessorID"].Value.ToString();
                break;
            }
            return ProcessorId;
        }

        public static string getSid(string hid)
        {
            var sid = Convert.ToBase64String(Encoding.UTF8.GetBytes(getHid()));
            return sid;
        }

        public static void registryEditor(string keyName, string keyValue)
        {
            RegistryKey regEdit;
            regEdit = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);

            regEdit.CreateSubKey("MyApplication");
            Registry.SetValue(@"\HKEY_CURRENT_USER\SOFTWARE\MyApplication", keyName, keyValue);
        }

        public static string GetRegValue(string keyName)
        {
            string licValue = (string)Registry.GetValue(@"\HKEY_CURRENT_USER\SOFTWARE\MyApplication", keyName, null);
            return licValue;
        }
    }
}
