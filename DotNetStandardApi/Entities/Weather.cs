using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    /// <summary>
    /// The current weather
    /// </summary>
    public partial class Weather
    {
        [JsonPropertyName("solarIntensity")]
        public SolarIntensity SolarIntensity { get; set; }

        [JsonPropertyName("outsideTemperature")]
        public OutsideTemperature OutsideTemperature { get; set; }

        [JsonPropertyName("weatherState")]
        public WeatherState WeatherState { get; set; }
    }
}