using Newtonsoft.Json;

namespace RestfulBooker.Models.GetBooking
{
    public class GetBookingResponse
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
        public GetBookingDatesResponse BookingDatesResponse { get; set; }
        
        [JsonProperty("additionalneeds")]
        public string AdditionalNeeds { get; set; }
    }
}