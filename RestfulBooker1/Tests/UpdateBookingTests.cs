using System;
using System.Net;
using NUnit.Framework;
using RestfulBooker1.Helpers;
using RestfulBooker1.Models.UpdateBooking.UpdateBookingRequest;
using RestfulBooker1.Models.UpdateBooking.UpdateBookingResponse;
using RestfulBooker1.Services;
using RestSharp;

namespace RestfulBooker1.Tests
{
    public class UpdateBookingTests
    {
        [Test]
        public void SuccessfulBookingUpdate()
        {
            UpdateBookingService service = new UpdateBookingService(ConfigHelper.WEB_API_URL);

            RestResponse<UpdateBookingResponse> response = service.UpdateBooking("Hazim", "Okanovic", 50, false,
                new UpdateBookingDatesRequest(DateTime.Today.AddDays(-5).ToString("MM/dd/yyyy"),
                    DateTime.Today.AddDays(+2).ToString("MM/dd/yyy")), "Sleeping bag");
            
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.FirstName, Is.EqualTo("Hazim"));
            Assert.That(response.Data.LastName, Is.EqualTo("Okanovic"));
            Assert.That(response.Data.TotalPrice, Is.EqualTo(50));
            Assert.That(response.Data.DepositPaid, Is.EqualTo(false));
            Assert.That(response.Data.AdditionalNeeds, Is.EqualTo("Sleeping bag"));
        }
        
        [Test]
        public void InvalidBookingUpdate()
        {
            UpdateBookingService service = new UpdateBookingService(ConfigHelper.WEB_API_URL);

            RestResponse<UpdateBookingResponse> response = service.ErrorUpdateBooking("Hazim", "Okanovic", 50, false,
                "Sleeping bag");
            
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest));
        }
        
        [Test]
        public void BookingUpdateWithoutAuthorisation()
        {
            UpdateBookingService service = new UpdateBookingService(ConfigHelper.WEB_API_URL);

            RestResponse<UpdateBookingResponse> response = service.UpdateBookingNoAuth("Hazim", "Okanovic", 50, false,
                new UpdateBookingDatesRequest(DateTime.Today.AddDays(-5).ToString("MM/dd/yyyy"),
                    DateTime.Today.AddDays(+2).ToString("MM/dd/yyy")), "Sleeping bag");
            
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Forbidden));
        }
    }
}