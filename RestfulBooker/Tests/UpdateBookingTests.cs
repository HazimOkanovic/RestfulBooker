using System;
using System.Net;
using NUnit.Framework;
using RestfulBooker.Helpers;
using RestfulBooker.Models.UpdateBooking.UpdateBookingRequest;
using RestfulBooker.Models.UpdateBooking.UpdateBookingResponse;
using RestfulBooker.Services;
using RestSharp;

namespace RestfulBooker.Tests
{
    public class UpdateBookingTests
    {
        [Test]
        public void SuccessfulBookingUpdate()
        {
            UpdateBookingService service = new UpdateBookingService(ConfigHelper.WEB_API_URL);

            RestResponse<UpdateBookingResponse> response = service.UpdateBooking(Constants.MyName, Constants.MySurname, 50, false,
                new UpdateBookingDatesRequest(DateTime.Today.AddDays(-5).ToString("MM/dd/yyyy"),
                    DateTime.Today.AddDays(+2).ToString("MM/dd/yyy")), Constants.SleepingBag);
            
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Data.FirstName, Is.EqualTo(Constants.MyName));
            Assert.That(response.Data.LastName, Is.EqualTo(Constants.MySurname));
            Assert.That(response.Data.TotalPrice, Is.EqualTo(50));
            Assert.That(response.Data.DepositPaid, Is.EqualTo(false));
            Assert.That(response.Data.AdditionalNeeds, Is.EqualTo(Constants.SleepingBag));
        }
        
        [Test]
        public void InvalidBookingUpdate()
        {
            UpdateBookingService service = new UpdateBookingService(ConfigHelper.WEB_API_URL);

            RestResponse<UpdateBookingResponse> response = service.ErrorUpdateBooking(Constants.MyName, Constants.MySurname, 50, false,
                Constants.SleepingBag);
            
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest));
        }
        
        [Test]
        public void BookingUpdateWithoutAuthorisation()
        {
            UpdateBookingService service = new UpdateBookingService(ConfigHelper.WEB_API_URL);

            RestResponse<UpdateBookingResponse> response = service.UpdateBookingNoAuth(Constants.MyName, Constants.MySurname, 50, false,
                new UpdateBookingDatesRequest(DateTime.Today.AddDays(-5).ToString("MM/dd/yyyy"),
                    DateTime.Today.AddDays(+2).ToString("MM/dd/yyy")), Constants.SleepingBag);
            
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Forbidden));
        }
    }
}