using System;
using RestfulBooker.Helpers;
using RestfulBooker.Models.GetBooking;
using RestSharp;

namespace RestfulBooker.Services
{
    public class GetBookingService : BaseService
    {
        public GetBookingService(string baseUrl) : base(baseUrl)
        {
            new CreateBookingHelper().CreateBooking();
        }
        
        public RestResponse<GetBookingResponse> GetBooking()
        {
            var rsp = GetAsyncWithParameter<GetBookingResponse>("/booking/" + CreateBookingHelper.BookingId).Result;
            Console.WriteLine("--------");
            Console.WriteLine("Booking get response content: " + rsp.Content);
            Console.WriteLine("--------");
            return rsp;
        }
    }
}