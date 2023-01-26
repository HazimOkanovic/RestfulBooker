using System.Net;
using NUnit.Framework;
using RestfulBooker.Helpers;
using RestfulBooker.Services;
using RestSharp;

namespace RestfulBooker.Tests
{
    public class DeleteBookingTest
    {
        [Test]
        public void DeleteBooking()
        {
            DeleteBookingService service = new DeleteBookingService(ConfigHelper.WEB_API_URL);

            RestResponse response = service.DeleteBooking();
            
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        }
        
        [Test]
        public void UnsuccessfulDeleteBooking()
        {
            DeleteBookingService service = new DeleteBookingService(ConfigHelper.WEB_API_URL);

            RestResponse response = service.DeleteBookingWithIncorrectId();
            
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.MethodNotAllowed));
        }
    }
}