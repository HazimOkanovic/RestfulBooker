using System;
using RestfulBooker1.Helpers;
using RestSharp;

namespace RestfulBooker1.Services
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