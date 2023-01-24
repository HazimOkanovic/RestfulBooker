using Newtonsoft.Json;

namespace RestfulBooker.Models.PartialBookingUpdate.Request
{
    public class FirstAndLastNameUpdateRequest
    {
        [JsonProperty("firstname")]
        public string FirstName { get; set; }
        
        [JsonProperty("lastname")]
        public string LastName { get; set; }

        public FirstAndLastNameUpdateRequest(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}