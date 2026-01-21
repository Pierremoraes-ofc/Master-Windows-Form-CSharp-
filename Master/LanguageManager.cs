using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Master
{
    public static class LanguageManager
    {
        private static Dictionary<string, string> _flat;

        public static void Load(string language)
        {
            AppPaths.EnsureDirectories();

            string path = Path.Combine(AppPaths.Language, $"{language}.json");
            if (!File.Exists(path))
                return;

            using var doc = JsonDocument.Parse(File.ReadAllText(path));

            _flat = new Dictionary<string, string>();
            FlattenJson(doc.RootElement, "", _flat);
        }

        public static string Get(string key)
        {
            if (_flat == null)
                return key;

            return _flat.TryGetValue(key, out var value)
                ? value
                : key;
        }

        // 🔁 RECURSIVO (suporta infinitas camadas)
        private static void FlattenJson(
            JsonElement element,
            string prefix,
            Dictionary<string, string> dict)
        {
            foreach (var prop in element.EnumerateObject())
            {
                string currentKey =
                    string.IsNullOrEmpty(prefix)
                    ? prop.Name
                    : $"{prefix}.{prop.Name}";

                if (prop.Value.ValueKind == JsonValueKind.Object)
                {
                    FlattenJson(prop.Value, currentKey, dict);
                }
                else
                {
                    dict[currentKey] = prop.Value.ToString();
                }
            }
        }
    }

}
