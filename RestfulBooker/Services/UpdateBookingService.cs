using System;
using RestfulBooker.Helpers;
using RestfulBooker.Models.UpdateBooking.UpdateBookingRequest;
using RestfulBooker.Models.UpdateBooking.UpdateBookingResponse;
using RestSharp;

namespace RestfulBooker.Services
{
    public class UpdateBookingService : BaseService
    {
        public UpdateBookingService(string baseUrl) : base(baseUrl)
        {
            new CreateBookingHelper().CreateBooking();
            new CreateTokenHelper().CreateToken();
        }
        
        public RestResponse<UpdateBookingResponse> UpdateBooking(string firstName, string lastName, int totalPrice, bool depositPaid, UpdateBookingDatesRequest bookingDatesRequest, string additionalNeeds)
        {
            var rsp = PutAsync<UpdateBookingRequest, UpdateBookingResponse>(
                "/booking/" + CreateBookingHelper.BookingId,
                new UpdateBookingRequest(firstName, lastName, totalPrice, depositPaid, bookingDatesRequest,
                    additionalNeeds), CreateTokenHelper.Token
            ).Result;
            
            Console.WriteLine("------");
            Console.WriteLine("Update booking content: " + rsp.Content);
            Console.WriteLine("------");
            return rsp;
        }
        
        public RestResponse<UpdateBookingResponse> UpdateBookingNoAuth(string firstName, string lastName, int totalPrice, bool depositPaid, UpdateBookingDatesRequest bookingDatesRequest, string additionalNeeds)
        {
            var rsp = PutAsyncWithoutAuth<UpdateBookingRequest, UpdateBookingResponse>(
                "/booking/" + CreateBookingHelper.BookingId,
                new UpdateBookingRequest(firstName, lastName, totalPrice, depositPaid, bookingDatesRequest,
                    additionalNeeds), CreateTokenHelper.Token
            ).Result;
            
            Console.WriteLine("------");
            Console.WriteLine("Update booking content: " + rsp.Content);
            Console.WriteLine("------");
            return rsp;
        }
        
        public RestResponse<UpdateBookingResponse> ErrorUpdateBooking(string firstName, string lastName, int totalPrice, bool depositPaid, string additionalNeeds)
        {
            var rsp = PutAsync<UpdateBookingErrorRequest, UpdateBookingResponse>(
                "/booking/" + CreateBookingHelper.BookingId,
                new UpdateBookingErrorRequest(firstName, lastName, totalPrice, depositPaid, additionalNeeds), CreateTokenHelper.Token
            ).Result;
            
            Console.WriteLine("------");
            Console.WriteLine("Update booking content: " + rsp.Content);
            Console.WriteLine("------");
            return rsp;
        }
    }
}