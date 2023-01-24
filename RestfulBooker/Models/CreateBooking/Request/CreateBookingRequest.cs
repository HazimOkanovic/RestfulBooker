using Newtonsoft.Json;

namespace RestfulBooker.Models.CreateBooking.Request
{
    public class CreateBookingRequest
    {
        [JsonProperty("firstname")]
        public string Firstname { get; set; } 
                
        [JsonProperty("lastname")]
        public string Lastname { get; set; }
        
        [JsonProperty("totalprice")]
        public int TotalPrice { get; set; }
        
        [JsonProperty("depositpaid")]
        public bool DepositPaid { get; set; }

        [JsonProperty("bookingdates")]
        public BookingDatesRequest BookingDates { get; set; }
        
        [JsonProperty("additionalneeds")]
        public string AdditionalNeeds { get; set; }

        public CreateBookingRequest(string firstname, string lastname, int totalPrice, bool depositPaid, BookingDatesRequest bookingDates, string additionalNeeds)
        {
            Firstname = firstname;
            Lastname = lastname;
            TotalPrice = totalPrice;
            DepositPaid = depositPaid;
            BookingDates = bookingDates;
            AdditionalNeeds = additionalNeeds;
        }
    }
}