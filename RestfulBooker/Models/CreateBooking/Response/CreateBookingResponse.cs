using Newtonsoft.Json;

namespace RestfulBooker.Models.CreateBooking.Response
{
    public class CreateBookingResponse
    {
        [JsonProperty("bookingid")]
        public int BookingId { get; set; }
        
        [JsonProperty("booking")]
        public BookingResponse Booking { get; set; }
    }
}