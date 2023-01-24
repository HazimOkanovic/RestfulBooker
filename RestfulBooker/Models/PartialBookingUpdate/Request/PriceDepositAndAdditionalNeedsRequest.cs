using Newtonsoft.Json;

namespace RestfulBooker.Models.PartialBookingUpdate.Request
{
    public class PriceDepositAndAdditionalNeedsRequest
    {
        [JsonProperty("totalprice")]
        public int TotalPrice { get; set; }
        
        [JsonProperty("depositpaid")]
        public bool DepositPaid { get; set; }

        [JsonProperty("additionalneeds")]
        public string AdditionalNeeds { get; set; }

        public PriceDepositAndAdditionalNeedsRequest(int totalPrice, bool depositPaid, string additionalNeeds)
        {
            TotalPrice = totalPrice;
            DepositPaid = depositPaid;
            AdditionalNeeds = additionalNeeds;
        }
    }
}