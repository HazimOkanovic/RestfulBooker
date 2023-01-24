using Newtonsoft.Json;

namespace RestfulBooker.Models.UpdateBooking.UpdateBookingRequest
{
    public class UpdateBookingErrorRequest
    {
        [JsonProperty("firstname")]
        public string Firstname { get; set; } 
                
        [JsonProperty("lastname")]
        public string Lastname { get; set; }
        
        [JsonProperty("totalprice")]
        public int TotalPrice { get; set; }
        
        [JsonProperty("depositpaid")]
        public bool DepositPaid { get; set; }

        [JsonProperty("additionalneeds")]
        public string AdditionalNeeds { get; set; }

        public UpdateBookingErrorRequest(string firstname, string lastname, int totalPrice, bool depositPaid, string additionalNeeds)
        {
            Firstname = firstname;
            Lastname = lastname;
            TotalPrice = totalPrice;
            DepositPaid = depositPaid;
            AdditionalNeeds = additionalNeeds;
        }
    }
}