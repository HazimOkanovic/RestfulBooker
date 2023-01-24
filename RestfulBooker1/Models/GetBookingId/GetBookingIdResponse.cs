using Newtonsoft.Json;

namespace RestfulBooker1.Models.GetBookingId
{
    public class GetBookingIdResponse
    {
        [JsonProperty("bookingid")]
        public int BookingId { get; set; } 
    }
}