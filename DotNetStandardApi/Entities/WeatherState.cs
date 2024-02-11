using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    public partial class WeatherState
    {
        [JsonPropertyName("type")]
        public string CurrentType { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("timestamp")]
        public System.DateTime Timestamp { get; set; }
    }
}