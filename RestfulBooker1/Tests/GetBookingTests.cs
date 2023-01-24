using NUnit.Framework;
using RestfulBooker1.Helpers;
using RestfulBooker1.Models.GetBooking;
using RestfulBooker1.Services;
using RestSharp;

namespace RestfulBooker1.Tests
{
    public class GetBookingTests
    {
        [Test]
        public void GetBooking()
        {
            GetBookingService service = new GetBookingService(ConfigHelper.WEB_API_URL);

            RestResponse<GetBookingResponse> response = service.GetBooking();
            
            Assert.That(response.Data.FirstName, Is.EqualTo(Constants.FirstName));
            Assert.That(response.Data.LastName, Is.EqualTo(Constants.LastName));
            Assert.That(response.Data.TotalPrice, Is.EqualTo(200));
            Assert.That(response.Data.DepositPaid, Is.EqualTo(true));
            Assert.That(response.Data.AdditionalNeeds, Is.EqualTo("nothing"));
        }
    }
}