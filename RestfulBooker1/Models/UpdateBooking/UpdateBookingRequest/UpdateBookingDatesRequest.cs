using Newtonsoft.Json;

namespace RestfulBooker1.Models.UpdateBooking.UpdateBookingRequest
{
    public class UpdateBookingDatesRequest
    {
        [JsonProperty("checkin")]
        public string CheckIn { get; set; }
        
        [JsonProperty("checkout")]
        public string CheckOut { get; set; }

        public UpdateBookingDatesRequest(string checkIn, string checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
    }
}