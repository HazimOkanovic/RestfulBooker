using Newtonsoft.Json;

namespace RestfulBooker1.Models.CreateToken.Response
{
    public class CreateTokenResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; } 
    }
}