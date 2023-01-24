using System;
using System.Collections.Generic;
using RestfulBooker.Models.GetBookingId;
using RestSharp;

namespace RestfulBooker.Services
{
    public class GetBookingIdService : BaseService
    {
        public GetBookingIdService(string baseUrl) : base(baseUrl)
        {
        }
        
        public RestResponse<List<GetBookingIdResponse>> GetBookingId()
        {
            var rsp = GetAsync<List<GetBookingIdResponse>>("/booking").Result;
            Console.WriteLine("--------");
            Console.WriteLine("Get booking id content: " + rsp.Content);
            Console.WriteLine("--------");
            return rsp;
        }
        
        public RestResponse<List<GetBookingIdResponse>> GetBookingIdWithHelper(string firstName, string lastName)
        {
            var rsp = GetAsyncWithParameters<List<GetBookingIdResponse>>("/booking", firstName, lastName).Result;
            Console.WriteLine("--------");
            Console.WriteLine("Monitor get response content: " + rsp.Content);
            Console.WriteLine("--------");
            return rsp;
        }
    }
}