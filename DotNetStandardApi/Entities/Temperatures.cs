using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    public partial class Temperatures
    {
        [JsonPropertyName("celsius")]
        public TemperatureSteps Celsius { get; set; }

        [JsonPropertyName("fahrenheit")]
        public TemperatureSteps Fahrenheit { get; set; }
    }
}