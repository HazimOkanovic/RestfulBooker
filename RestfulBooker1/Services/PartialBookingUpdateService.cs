using System;
using RestfulBooker1.Helpers;
using RestfulBooker1.Models.PartialBookingUpdate.Request;
using RestfulBooker1.Models.PartialBookingUpdate.Response;
using RestSharp;

namespace RestfulBooker1.Services
{
    public class PartialBookingUpdateService : BaseService
    {
         public PartialBookingUpdateService(string baseUrl) : base(baseUrl)
        {
            new CreateBookingHelper().CreateBooking();
            new CreateTokenHelper().CreateToken();
        }
        
        public RestResponse<PartialBookingUpdateResponse> FirstAndLastNameUpdate(string firstName, string lastName)
        {
            var rsp = PutAsync<FirstAndLastNameUpdateRequest, PartialBookingUpdateResponse>(
                "/booking/" + CreateBookingHelper.BookingId,
                new FirstAndLastNameUpdateRequest(firstName, lastName), CreateTokenHelper.Token
            ).Result;
            
            Console.WriteLine("------");
            Console.WriteLine("Update booking content: " + rsp.Content);
            Console.WriteLine("------");
            return rsp;
        }
        
        public RestResponse<PartialBookingUpdateResponse> PriceDepositAndNeedsUpdate(int price, bool paidDeposit, string additionalNeeds)
        {
            var rsp = PutAsync<PriceDepositAndAdditionalNeedsRequest, PartialBookingUpdateResponse>(
                "/booking/" + CreateBookingHelper.BookingId,
                new PriceDepositAndAdditionalNeedsRequest(price, paidDeposit, additionalNeeds), CreateTokenHelper.Token
            ).Result;
            
            Console.WriteLine("------");
            Console.WriteLine("Update booking content: " + rsp.Content);
            Console.WriteLine("------");
            return rsp;
        }
        
        public RestResponse<PartialBookingUpdateResponse> PartialUpdateBookingNoAuth(string firstName, string lastName)
        {
            var rsp = PutAsyncWithoutAuth<FirstAndLastNameUpdateRequest, PartialBookingUpdateResponse>(
                "/booking/" + CreateBookingHelper.BookingId,
                new FirstAndLastNameUpdateRequest(firstName, lastName), CreateTokenHelper.Token
            ).Result;
            
            Console.WriteLine("------");
            Console.WriteLine("Update booking content: " + rsp.Content);
            Console.WriteLine("------");
            return rsp;
        }
        
        public RestResponse<PartialBookingUpdateResponse> ErrorPartialUpdateBooking(string firstName, string lastName)
        {
            var rsp = PutAsync<FirstAndLastNameUpdateRequest, PartialBookingUpdateResponse>(
                "/booking/" + CreateBookingHelper.BookingId,
                new FirstAndLastNameUpdateRequest(firstName, lastName), CreateTokenHelper.Token
            ).Result;
            
            Console.WriteLine("------");
            Console.WriteLine("Update booking content: " + rsp.Content);
            Console.WriteLine("------");
            return rsp;
        }
    }
}