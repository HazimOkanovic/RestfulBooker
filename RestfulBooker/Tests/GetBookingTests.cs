using NUnit.Framework;
using RestfulBooker.Helpers;
using RestfulBooker.Models.GetBooking;
using RestfulBooker.Services;
using RestSharp;

namespace RestfulBooker.Tests
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
            Assert.That(response.Data.AdditionalNeeds, Is.EqualTo(Constants.Nothing));
        }
    }
}