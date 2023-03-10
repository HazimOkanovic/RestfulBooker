using System;
using System.Net;
using NUnit.Framework;
using RestfulBooker.Helpers;
using RestfulBooker.Models.CreateBooking.Request;
using RestfulBooker.Models.CreateBooking.Response;
using RestfulBooker.Services;
using RestSharp;

namespace RestfulBooker.Tests
{
    public class CreateBookingTests
    {
        [Test]
        public void SuccessfulCreateBooking()
        {
            CreateBookingService service = new CreateBookingService(ConfigHelper.WEB_API_URL);

            RestResponse<CreateBookingResponse> createBookingResponse =
                service.CreateBooking(Constants.FirstName, Constants.LastName, 99, true, new BookingDatesRequest(DateTime.Today.Date.ToString("yyyy-MM-dd"), DateTime.Today.Date.AddDays(+5).ToString("yyyy-MM-dd")), Constants.Breakfast);
                
            Assert.That(createBookingResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(createBookingResponse.Data.Booking.DepositPaid, Is.EqualTo(true));
            Assert.That(createBookingResponse.Data.Booking.FirstName, Is.EqualTo(Constants.FirstName));
            Assert.That(createBookingResponse.Data.Booking.LastName, Is.EqualTo(Constants.LastName));
            Assert.That(createBookingResponse.Data.Booking.TotalPrice, Is.EqualTo(99));
            Assert.That(createBookingResponse.Data.Booking.AdditionalNeeds, Is.EqualTo(Constants.Breakfast));
        }
        
        [Test]
        public void CreateBookingWithoutFirstName()
        {
            CreateBookingService service = new CreateBookingService(ConfigHelper.WEB_API_URL);

            RestResponse<CreateBookingResponse> createBookingResponse =
                service.CreateBooking("", Constants.LastName, 99, true, new BookingDatesRequest(DateTime.Today.Date.ToString("yyyy-MM-dd"), DateTime.Today.Date.AddDays(+5).ToString("yyyy-MM-dd")), Constants.Breakfast);
                
            Assert.That(createBookingResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(createBookingResponse.Data.Booking.DepositPaid, Is.EqualTo(true));
            Assert.That(createBookingResponse.Data.Booking.LastName, Is.EqualTo(Constants.LastName));
            Assert.That(createBookingResponse.Data.Booking.TotalPrice, Is.EqualTo(99));
            Assert.That(createBookingResponse.Data.Booking.AdditionalNeeds, Is.EqualTo(Constants.Breakfast));
        }
        
        [Test]
        public void CreateBookingWithoutFirstAndLastName()
        {
            CreateBookingService service = new CreateBookingService(ConfigHelper.WEB_API_URL);

            RestResponse<CreateBookingResponse> createBookingResponse =
                service.CreateBooking("", "", 99, true, new BookingDatesRequest(DateTime.Today.Date.ToString("yyyy-MM-dd"), DateTime.Today.Date.AddDays(+5).ToString("yyyy-MM-dd")), Constants.Breakfast);
                
            Assert.That(createBookingResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(createBookingResponse.Data.Booking.DepositPaid, Is.EqualTo(true));
            Assert.That(createBookingResponse.Data.Booking.TotalPrice, Is.EqualTo(99));
            Assert.That(createBookingResponse.Data.Booking.AdditionalNeeds, Is.EqualTo(Constants.Breakfast));
        }
        
        [Test]
        public void CreateBookingWithoutCheckInAndCheckOutDate()
        {
            CreateBookingService service = new CreateBookingService(ConfigHelper.WEB_API_URL);

            RestResponse<CreateBookingResponse> createBookingResponse =
                service.CreateBooking(Constants.FirstName, Constants.LastName, 99, true, new BookingDatesRequest("", ""), Constants.Breakfast);
                
            Assert.That(createBookingResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(createBookingResponse.Data.Booking.DepositPaid, Is.EqualTo(true));
            Assert.That(createBookingResponse.Data.Booking.FirstName, Is.EqualTo(Constants.FirstName));
            Assert.That(createBookingResponse.Data.Booking.LastName, Is.EqualTo(Constants.LastName));
            Assert.That(createBookingResponse.Data.Booking.TotalPrice, Is.EqualTo(99));
            Assert.That(createBookingResponse.Data.Booking.AdditionalNeeds, Is.EqualTo(Constants.Breakfast));
        }
    }
}