using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    public class TemperatureSteps
    {
        [JsonPropertyName("min")]
        public long Min { get; set; }

        [JsonPropertyName("max")]
        public long Max { get; set; }

        [JsonPropertyName("step")]
        public long Step { get; set; }
    }
}