using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextboxForPhoneNumbers
{
    internal static class AppExtensions
    {
        public static void UncheckAllItems(this System.Windows.Forms.CheckedListBox clb)
        {
            while (clb.CheckedIndices.Count > 0)
                clb.SetItemChecked(clb.CheckedIndices[0], false);
        }
        public static void OpenURL(string url)
        {
            string key = @"htmlfile\shell\open\command";
            RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(key, false);
            string Default_Browser_Path = ((string)registryKey.GetValue(null, null)).Split('"')[1];
            Process p = new Process();
            p.StartInfo.FileName = Default_Browser_Path;
            p.StartInfo.Arguments = url;
            p.Start();
        }
    }
}