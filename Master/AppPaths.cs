using System;
using System.Collections.Generic;
using System.Text;

namespace Master
{
    public static class AppPaths
    {
        public static readonly string Root =
            Application.StartupPath;

        public static readonly string Preferences =
            Path.Combine(Root, "Preferences");

        public static readonly string Language =
            Path.Combine(Preferences, "Language");

        public static readonly string Profiles =
            Path.Combine(Preferences, "Perfis");

        public static readonly string Settings =
            Path.Combine(Preferences, "Settings.json");

        public static void EnsureDirectories()
        {
            Directory.CreateDirectory(Preferences);
            Directory.CreateDirectory(Language);
            Directory.CreateDirectory(Profiles);
        }
    }
}
