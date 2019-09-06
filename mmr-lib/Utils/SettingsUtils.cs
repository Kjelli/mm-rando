using MMRando.Models;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MMRando.Utils
{
    public static class SettingsUtils
    {
        internal static byte[] GetGenerationSettingsHash(ISettings settings)
        {
            string field = GetGenerationSettings(settings);
            if (!settings.OutputTextSpoiler && !settings.OutputHTMLSpoiler)
            {
                field += "bad salt by mzxrules";
            }

            byte[] hash;
            using (var sha256 = SHA256.Create())
            {
                hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(field));
            }
            return hash;
        }

        public static string GetGenerationSettings(ISettings settings)
        {
            string settingsSerialized = JsonConvert.SerializeObject(settings);
            var settingsObj = JsonConvert.DeserializeObject<GenerationSettings>
                (settingsSerialized);
            return JsonConvert.SerializeObject(settingsObj);
        }

        public static string Stringify(ISettings settings)
        {
            var hash = GetGenerationSettingsHash(settings);
            return string.Concat(hash.Select(x => x.ToString("X2")));
        }

        public static Settings LoadFromFile(string filename)
        {
            if (!File.Exists(filename))
            {
                return new Settings();
            }

            var json = File.ReadAllText(filename);
            var jsonSettings = new JsonSerializerSettings
            {
                Error = delegate (object sender, Newtonsoft.Json.Serialization.ErrorEventArgs args)
                {
                    System.Diagnostics.Debug.WriteLine(args.ErrorContext.Error.Message);
                    args.ErrorContext.Handled = true;
                },
            };
            return JsonConvert.DeserializeObject<Settings>(json, jsonSettings);
        }
    }
}
