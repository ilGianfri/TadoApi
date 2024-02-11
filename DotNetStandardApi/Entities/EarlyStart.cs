using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    public class EarlyStart
    {
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
