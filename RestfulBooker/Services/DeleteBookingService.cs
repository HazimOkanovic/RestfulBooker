using System;
using RestfulBooker.Helpers;
using RestSharp;

namespace RestfulBooker.Services
{
    public class DeleteBookingService : BaseService
    {
        public DeleteBookingService(string baseUrl) : base(baseUrl)
        {
            new CreateBookingHelper().CreateBooking();
            new CreateTokenHelper().CreateToken();
        }

        RestResponse DeleteBooking()
        {
            var rsp = DeleteAsync("/booking/" + CreateBookingHelper.BookingId, CreateTokenHelper.Token).Result;
            Console.WriteLine("--------");
            Console.WriteLine("Delete booking content: " + rsp.Content);
            Console.WriteLine("--------");
            return rsp;
        }
    }
}