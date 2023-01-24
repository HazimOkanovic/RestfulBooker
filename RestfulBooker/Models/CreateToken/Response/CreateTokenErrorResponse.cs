using Newtonsoft.Json;

namespace RestfulBooker.Models.CreateToken.Response
{
    public class CreateTokenErrorResponse
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}