using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    public partial class Link
    {
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}