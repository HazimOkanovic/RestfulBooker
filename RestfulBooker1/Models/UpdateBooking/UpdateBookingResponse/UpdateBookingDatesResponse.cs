using Newtonsoft.Json;

namespace RestfulBooker1.Models.UpdateBooking.UpdateBookingResponse
{
    public class UpdateBookingDatesResponse
    {
        [JsonProperty("checkin")]
        public string CheckIn { get; set; }
        
        [JsonProperty("checkout")]
        public string CheckOut { get; set; }
    }
}