using Newtonsoft.Json;

namespace RestfulBooker1.Models.CreateBooking.Response
{
    public class CreateBookingResponse
    {
        [JsonProperty("bookingid")]
        public int BookingId { get; set; }
        
        [JsonProperty("booking")]
        public BookingResponse Booking { get; set; }
    }
}