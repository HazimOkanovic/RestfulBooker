using Newtonsoft.Json;

namespace RestfulBooker.Models.CreateToken.Response
{
    public class CreateTokenResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; } 
    }
}