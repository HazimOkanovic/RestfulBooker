using Newtonsoft.Json;

namespace RestfulBooker1.Models.PartialBookingUpdate.Response
{
    public class PartialUpdateBookingDatesResponse
    {
        [JsonProperty("checkin")]
        public string CheckIn { get; set; }
        
        [JsonProperty("checkout")]
        public string CheckOut { get; set; }
    }
}