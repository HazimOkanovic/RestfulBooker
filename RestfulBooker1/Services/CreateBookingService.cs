using System;
using RestfulBooker1.Models.CreateBooking.Request;
using RestfulBooker1.Models.CreateBooking.Response;
using RestSharp;

namespace RestfulBooker1.Services
{
    public class CreateBookingService : BaseService
    {
        public CreateBookingService(string baseUrl) : base(baseUrl)
        {
            
        }
        
        public RestResponse<CreateBookingResponse> CreateBooking(string firstName, string lastName, int totalPrice, bool depositPaid, BookingDatesRequest bookingDatesRequest, string additionalNeeds)
        {
            var rsp = PostAsync<CreateBookingRequest, CreateBookingResponse>(
                "/booking",
                new CreateBookingRequest(firstName, lastName, totalPrice, depositPaid, bookingDatesRequest, additionalNeeds)
            ).Result;
            
            Console.WriteLine("------");
            Console.WriteLine("Create booking content: " + rsp.Content);
            Console.WriteLine("------");
            return rsp;
        }
    }
}