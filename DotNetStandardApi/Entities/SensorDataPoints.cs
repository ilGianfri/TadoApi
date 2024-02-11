using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    /// <summary>
    /// Temperature and humidity measured by a Tado device
    /// </summary>
    public partial class SensorDataPoints
    {
        [JsonPropertyName("insideTemperature")]
        public InsideTemperature InsideTemperature { get; set; }

        [JsonPropertyName("humidity")]
        public Humidity Humidity { get; set; }
    }
}