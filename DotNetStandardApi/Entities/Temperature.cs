using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    /// <summary>
    /// Information regarding a temperature
    /// </summary>
    public partial class Temperature
    {
        /// <summary>
        /// The temperature in degrees Celcius
        /// </summary>
        [JsonPropertyName("celsius")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? Celsius { get; set; }

        /// <summary>
        /// The temperature in degrees Fahrenheit
        /// </summary>
        [JsonPropertyName("fahrenheit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? Fahrenheit { get; set; }
    }
}