using System;
using RestSharp;

namespace RestfulBooker1.Services
{
    public class CreateTokenService : BaseService
    {
        public CreateTokenService(string baseUrl) : base(baseUrl)
        {
            
        }
        
        public RestResponse<CreateTokenResponse> CreateToken(string username, string password)
        {
            var rsp = PostAsync<CreateTokenRequest, CreateTokenResponse>(
                "/auth",
                new CreateTokenRequest(username, password)
            ).Result;
            
            Console.WriteLine("------");
            Console.WriteLine("Create token content: " + rsp.Content);
            Console.WriteLine("------");
            return rsp;
        }
        
        public RestResponse<CreateTokenErrorResponse> CreateTokenError(string username, string password)
        {
            var rsp = PostAsync<CreateTokenRequest, CreateTokenErrorResponse>(
                "/auth",
                new CreateTokenRequest(username, password)
            ).Result;
            
            Console.WriteLine("Login request content:");
            Console.WriteLine("------");
            Console.WriteLine("Login response content: " + rsp.Content);
            Console.WriteLine("------");
            return rsp;
        }
    }
}