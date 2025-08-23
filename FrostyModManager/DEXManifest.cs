using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;

namespace DEXManifest
{
    public partial class Manifest
    {
        [JsonProperty("active_mods")]
        public List<ActiveMod> ActiveMods { get; set; }
    }

    public partial class ActiveMod
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("major_version")]
        public long MajorVersion { get; set; }

        [JsonProperty("minor_version")]
        public long MinorVersion { get; set; }

        [JsonProperty("required_extender_api_version")]
        public long RequiredExtenderApiVersion { get; set; }

        [JsonProperty("startup_scripts")]
        public List<string> StartupScripts { get; set; }

        [JsonIgnore]
        public string StartupScriptsJoin {
            get {
                return string.Join(", ", StartupScripts);
            }
        }
    }

    public partial class Manifest
    {
        public static Manifest FromJson(string json) => JsonConvert.DeserializeObject<Manifest>(json, DEXManifest.Converter.Settings);
    }

    public partial class ManifestActiveMod
    {
        public static ActiveMod FromJson(string json) => JsonConvert.DeserializeObject<ActiveMod>(json, DEXManifest.Converter.Settings);
    }


    public static class Serialize
    {
        public static string ToJson(this Manifest self) => JsonConvert.SerializeObject(self, DEXManifest.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
