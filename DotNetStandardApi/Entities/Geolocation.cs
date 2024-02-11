using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    public class Geolocation
    {
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }
    }
}