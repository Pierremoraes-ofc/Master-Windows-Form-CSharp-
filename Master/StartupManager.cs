using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;

namespace Master
{
    public static class StartupManager
    {
        private const string RunKey = @"Software\Microsoft\Windows\CurrentVersion\Run";

        private const string AppName = "Master";

        public static void Enable()
        {
            using (RegistryKey key =
                Registry.CurrentUser.OpenSubKey(RunKey, true))
            {
                key.SetValue(AppName, Application.ExecutablePath);
            }
        }

        public static void Disable()
        {
            using (RegistryKey key =
                Registry.CurrentUser.OpenSubKey(RunKey, true))
            {
                key.DeleteValue(AppName, false);
            }
        }

        public static bool IsEnabled()
        {
            using (RegistryKey key =
                Registry.CurrentUser.OpenSubKey(RunKey, false))
            {
                return key.GetValue(AppName) != null;
            }
        }
    }
}
