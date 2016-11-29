using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class RegKeys
    {
        static string names = "Names";
        public static void Create()
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(names);
            key.SetValue("Name", "Samu");
            key.Close();
        }

        public static void Read(string name)
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(names);
            Console.WriteLine(key.GetValue(name));
            key.Close();
        }
    }
}
