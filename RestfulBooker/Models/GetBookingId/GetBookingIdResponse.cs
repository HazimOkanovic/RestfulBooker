using Newtonsoft.Json;

namespace RestfulBooker.Models.GetBookingId
{
    public class GetBookingIdResponse
    {
        [JsonProperty("bookingid")]
        public int BookingId { get; set; } 
    }
}