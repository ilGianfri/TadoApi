using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    public partial class Precision
    {
        [JsonPropertyName("celsius")]
        public long Celsius { get; set; }

        [JsonPropertyName("fahrenheit")]
        public long Fahrenheit { get; set; }
    }

}