using Newtonsoft.Json;

namespace RestfulBooker1.Models.CreateToken.Response
{
    public class CreateTokenErrorResponse
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}