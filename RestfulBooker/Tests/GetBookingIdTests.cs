using System.Collections.Generic;
using System.Net;
using NUnit.Framework;
using RestfulBooker.Helpers;
using RestfulBooker.Models.GetBookingId;
using RestfulBooker.Services;
using RestSharp;

namespace RestfulBooker.Tests
{
    public class GetBookingIdTests
    {
        [Test]
        public void GetBookingId()
        {
            GetBookingIdService service = new GetBookingIdService(ConfigHelper.WEB_API_URL);

            RestResponse<List<GetBookingIdResponse>> getBookingResponse = service.GetBookingId();
            
            Assert.That(getBookingResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(getBookingResponse.Data[0].BookingId, Is.Not.Null);
        }
    }
}