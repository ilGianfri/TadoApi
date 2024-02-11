using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities.MobileDevice
{
    /// <summary>
    /// Contains detailed information about a device connected to Tado
    /// </summary>
    public class Details
    {
        [JsonPropertyName("platform")]
        public string Platform { get; set; }

        [JsonPropertyName("osVersion")]
        public string OsVersion { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("locale")]
        public string Locale { get; set; }
    }
}