using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    public class HeatingPower
    {
        [JsonPropertyName("type")]
        public string CurrentType { get; set; }

        [JsonPropertyName("percentage")]
        public long Percentage { get; set; }

        [JsonPropertyName("timestamp")]
        public System.DateTime Timestamp { get; set; }
    }
}