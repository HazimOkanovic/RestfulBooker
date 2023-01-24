using Newtonsoft.Json;

namespace RestfulBooker.Models.CreateToken.Request
{
    public class CreateTokenRequest
    {
        [JsonProperty("username")]
        public string Username { get; set; } 
                
        [JsonProperty("password")]
        public string Password { get; set; }

        public CreateTokenRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}