using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    /// <summary>
    /// Details about the current configuration of the dazzle mode (animation when changing the temperature)
    /// </summary>
    public partial class DazzleMode
    {
        [JsonPropertyName("supported")]
        public bool Supported { get; set; }

        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}