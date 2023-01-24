using Newtonsoft.Json;

namespace RestfulBooker1.Models.CreateBooking.Response
{
    public class BookingDatesResponse
    {
        [JsonProperty("checkin")]
        public string CheckIn { get; set; }
        
        [JsonProperty("checkout")]
        public string CheckOut { get; set; }
    }
}