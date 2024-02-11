using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    public partial class Address
    {
        [JsonPropertyName("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonPropertyName("addressLine2")]
        public object AddressLine2 { get; set; }

        [JsonPropertyName("zipCode")]
        public string ZipCode { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public object State { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}