using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    public partial class SolarIntensity
    {
        [JsonPropertyName("type")]
        public string CurrentType { get; set; }

        [JsonPropertyName("percentage")]
        public long Percentage { get; set; }

        [JsonPropertyName("timestamp")]
        public System.DateTime Timestamp { get; set; }
    }
}