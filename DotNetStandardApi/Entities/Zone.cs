using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    /// <summary>
    /// Information about one zone
    /// </summary>
    public class Zone
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string CurrentType { get; set; }

        [JsonPropertyName("dateCreated")]
        public System.DateTime DateCreated { get; set; }

        [JsonPropertyName("deviceTypes")]
        public string[] DeviceTypes { get; set; }

        [JsonPropertyName("devices")]
        public Device[] Devices { get; set; }

        [JsonPropertyName("reportAvailable")]
        public bool ReportAvailable { get; set; }

        [JsonPropertyName("supportsDazzle")]
        public bool SupportsDazzle { get; set; }

        [JsonPropertyName("dazzleEnabled")]
        public bool DazzleEnabled { get; set; }

        [JsonPropertyName("dazzleMode")]
        public DazzleMode DazzleMode { get; set; }

        [JsonPropertyName("openWindowDetection")]
        public OpenWindowDetection OpenWindowDetection { get; set; }
    }
}