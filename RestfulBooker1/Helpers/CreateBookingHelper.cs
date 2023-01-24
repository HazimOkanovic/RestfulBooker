using System;
using RestfulBooker1.Models.CreateBooking.Request;
using RestfulBooker1.Models.CreateBooking.Response;
using RestfulBooker1.Services;
using RestSharp;

namespace RestfulBooker1.Helpers
{
    public class CreateBookingHelper
    {
        public static string BookingId { get; set; }
        
        public string CreateBooking()
        {
            CreateBookingService service = new CreateBookingService(ConfigHelper.WEB_API_URL);

            RestResponse<CreateBookingResponse> response = service.CreateBooking(Constants.FirstName,
                Constants.LastName, 200, true, new BookingDatesRequest(DateTime.Today.Date.ToString("MM/dd/yyyy"),
                    DateTime.Today.Date.ToString("MM/dd/yyyy")), "nothing");

            int bookingId = response.Data.BookingId;

            string id = bookingId.ToString();
            
            BookingId = id;

            return id;
        }
    }
}