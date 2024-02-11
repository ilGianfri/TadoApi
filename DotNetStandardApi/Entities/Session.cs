using System.Text.Json.Serialization;
using System;

namespace KoenZomers.Tado.Api.Entities
{
    /// <summary>
    /// Session token coming forward from an OAuth authentication request
    /// </summary>
    public class Session
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        private int? expiresIn;
        [JsonPropertyName("expires_in")]
        public int? ExpiresIn
        {
            get { return expiresIn; }
            set
            {
                expiresIn = value;
                Expires = value.HasValue ? (DateTime?) DateTime.Now.AddSeconds(value.Value) : null;
            }
        }

        /// <summary>
        /// Date and time at which the Access Token expires
        /// </summary>
        public DateTime? Expires { get; private set; }

        [JsonPropertyName("jti")]
        public string Jti { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }
    }
}
