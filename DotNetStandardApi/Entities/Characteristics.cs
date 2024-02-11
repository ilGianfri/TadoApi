using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    /// <summary>
    /// Characteristics of a device
    /// </summary>
    public class Characteristics
    {
        [JsonPropertyName("capabilities")]
        public string[] Capabilities { get; set; }
    }
}