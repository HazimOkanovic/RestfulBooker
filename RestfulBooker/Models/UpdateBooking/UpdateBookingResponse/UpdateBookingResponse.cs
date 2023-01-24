using Newtonsoft.Json;

namespace RestfulBooker.Models.UpdateBooking.UpdateBookingResponse
{
    public class UpdateBookingResponse
    {
        [JsonProperty("firstname")]
        public string FirstName { get; set; }
        
        [JsonProperty("lastname")]
        public string LastName { get; set; }
        
        [JsonProperty("totalprice")]
        public int TotalPrice { get; set; }
        
        [JsonProperty("depositpaid")]
        public bool DepositPaid { get; set; }
        
        [JsonProperty("bookingdates")]
        public UpdateBookingDatesResponse BookingDatesResponse { get; set; }
        
        [JsonProperty("additionalneeds")]
        public string AdditionalNeeds { get; set; }
    }
}