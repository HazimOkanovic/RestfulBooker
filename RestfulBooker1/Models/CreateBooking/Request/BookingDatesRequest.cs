using Newtonsoft.Json;

namespace RestfulBooker1.Models.CreateBooking.Request
{
    public class BookingDatesRequest
    {
        [JsonProperty("checkin")]
        public string CheckIn { get; set; }
        
        [JsonProperty("checkout")]
        public string CheckOut { get; set; }

        public BookingDatesRequest(string checkIn, string checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
    }
}