using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    public class ActivityDataPoints
    {
        [JsonPropertyName("heatingPower")]
        public HeatingPower HeatingPower { get; set; }
    }
}