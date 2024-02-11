using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    public partial class OutsideTemperature
    {
        [JsonPropertyName("celsius")]
        public double Celsius { get; set; }

        [JsonPropertyName("fahrenheit")]
        public double Fahrenheit { get; set; }

        [JsonPropertyName("timestamp")]
        public System.DateTime Timestamp { get; set; }

        [JsonPropertyName("type")]
        public string PurpleType { get; set; }

        [JsonPropertyName("precision")]
        public Precision Precision { get; set; }
    }
}