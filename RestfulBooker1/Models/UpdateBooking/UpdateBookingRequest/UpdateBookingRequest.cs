using Newtonsoft.Json;

namespace RestfulBooker1.Models.UpdateBooking.UpdateBookingRequest
{
    public class UpdateBookingRequest
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
        public UpdateBookingDatesRequest BookingDates { get; set; }
        
        [JsonProperty("additionalneeds")]
        public string AdditionalNeeds { get; set; }

        public UpdateBookingRequest(string firstname, string lastname, int totalPrice, bool depositPaid, UpdateBookingDatesRequest bookingDates, string additionalNeeds)
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