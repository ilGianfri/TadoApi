using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    /// <summary>
    /// Humidity measured by a Tado device
    /// </summary>
    public partial class Humidity
    {
        [JsonPropertyName("type")]
        public string CurrentType { get; set; }

        [JsonPropertyName("percentage")]
        public double Percentage { get; set; }

        [JsonPropertyName("timestamp")]
        public System.DateTime Timestamp { get; set; }
    }
}