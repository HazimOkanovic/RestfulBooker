using Newtonsoft.Json;

namespace RestfulBooker1.Models.GetBooking
{
    public class GetBookingDatesResponse
    {
        [JsonProperty("checkin")]
        public string CheckIn { get; set; }
        
        [JsonProperty("checkout")]
        public string CheckOut { get; set; }
    }
}