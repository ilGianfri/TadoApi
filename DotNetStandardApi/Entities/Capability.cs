using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    public class Capability
    {
        [JsonPropertyName("type")]
        public string PurpleType { get; set; }

        [JsonPropertyName("temperatures")]
        public Temperatures Temperatures { get; set; }
    }
}