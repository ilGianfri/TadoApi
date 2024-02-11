using System.Text.Json.Serialization;

namespace KoenZomers.Tado.Api.Entities
{
    public partial class Overlay
    {
        /// <summary>
        /// The current state of the Tado device
        /// </summary>
        [JsonPropertyName("setting")]
        public Setting Setting { get; set; }

        /// <summary>
        /// Information on when the current state of the Tado device will end
        /// </summary>
        [JsonPropertyName("termination")]
        public Termination Termination { get; set; }
    }
}