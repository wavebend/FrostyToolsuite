using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FrostyModManager
{
    public class ActiveMod
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
        public string StartupScriptsJoin => string.Join(", ", StartupScripts); //Used by MainWindow.xaml
    }

    public abstract class Manifest
    {
        public static ActiveMod FromJson(string json) => JsonConvert.DeserializeObject<ActiveMod>(json, Converter.Settings);
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
