using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace RestfulBooker.Services
{
    public class BaseService
    {
        protected readonly RestClient _client;
        protected readonly string _acceptedContentType = "application/json";
        protected readonly string _accept = "application/json";

        public BaseService(string baseUrl)
        {
            var options = new RestClientOptions(baseUrl);
            _client = new RestClient(options);
        }
        
        public async Task<RestResponse> DeleteAsync(string endpoint, string token)
        {
            var request = new RestRequest(endpoint, Method.Delete);
            
            request.AddHeader("Accept", _accept);
            request.AddHeader("Cookie", token);
            _client.Authenticator = new HttpBasicAuthenticator(Constants.ValidUsername, Constants.ValidPassword);
            return await _client.ExecuteAsync(request);
        } 

        public async Task<RestResponse<T>> DeleteAsync<T>(string endpoint, T body)
        {
            var jsonBody = JsonConvert.SerializeObject(body);

            var restRequest = new RestRequest(endpoint, Method.Delete)
                .AddParameter(_acceptedContentType, jsonBody, ParameterType.RequestBody);

            return await _client.ExecuteAsync<T>(restRequest);
        }

        public async Task<RestResponse<T>> GetAsync<T>(string endpoint)
        {
            var restRequest = new RestRequest(endpoint, Method.Get);
            Console.WriteLine(_client.Options.BaseUrl + endpoint);
            return await _client.ExecuteAsync<T>(restRequest);
        }
        
        public async Task<RestResponse<T>> GetAsyncWithParameters<T>(string endpoint, string firstName, string lastName)
        {
            var restRequest = new RestRequest(endpoint, Method.Get)
                .AddParameter("firstname", firstName)
                .AddParameter("lastname", lastName);
            Console.WriteLine(_client.Options.BaseUrl + endpoint);
            return await _client.ExecuteAsync<T>(restRequest);
        }
        
        public async Task<RestResponse<T>> GetAsyncWithParameter<T>(string endpoint)
        {
            var restRequest = new RestRequest(endpoint, Method.Get);
            restRequest.AddHeader("Accept", _accept);
            Console.WriteLine(_client.Options.BaseUrl + endpoint);
            return await _client.ExecuteAsync<T>(restRequest);
        }

        public async Task<RestResponse<W>> PostAsync<T,W>(string endpoint, T body)
        {
            string jsonBody = JsonConvert.SerializeObject(body);
            var restRequest = new RestRequest(endpoint, Method.Post)
                .AddParameter(_acceptedContentType, jsonBody, ParameterType.RequestBody);
            
            restRequest.AddHeader("Accept", _accept);
            
            return await _client.ExecuteAsync<W>(restRequest);
        }
        
        public async Task<RestResponse<W>> PatchAsync<T,W>(string endpoint, T body, string token)
        {
            string jsonBody = JsonConvert.SerializeObject(body);
            var restRequest = new RestRequest(endpoint, Method.Patch)
                .AddParameter(_acceptedContentType, jsonBody, ParameterType.RequestBody);
            
            restRequest.AddHeader("Accept", _accept);
            restRequest.AddHeader("Cookie", token);
            _client.Authenticator = new HttpBasicAuthenticator(Constants.ValidUsername, Constants.ValidPassword);
            
            return await _client.ExecuteAsync<W>(restRequest);
        }
        
        public async Task<RestResponse<W>> PatchAsyncWithoutAuth<T,W>(string endpoint, T body, string token)
        {
            string jsonBody = JsonConvert.SerializeObject(body);
            var restRequest = new RestRequest(endpoint, Method.Patch)
                .AddParameter(_acceptedContentType, jsonBody, ParameterType.RequestBody);
            
            restRequest.AddHeader("Accept", _accept);
            restRequest.AddHeader("Cookie", token);

            return await _client.ExecuteAsync<W>(restRequest);
        }
        
        public async Task<RestResponse<W>> PutAsync<T,W>(string endpoint, T body, string token)
        {
            string jsonBody = JsonConvert.SerializeObject(body);
            var restRequest = new RestRequest(endpoint, Method.Put)
                .AddParameter(_acceptedContentType, jsonBody, ParameterType.RequestBody);
            
            restRequest.AddHeader("Accept", _accept);
            restRequest.AddHeader("Cookie", token);
            _client.Authenticator = new HttpBasicAuthenticator(Constants.ValidUsername, Constants.ValidPassword);
            
            return await _client.ExecuteAsync<W>(restRequest);
        }
        
        public async Task<RestResponse<W>> PutAsyncWithoutAuth<T,W>(string endpoint, T body, string token)
        {
            string jsonBody = JsonConvert.SerializeObject(body);
            var restRequest = new RestRequest(endpoint, Method.Put)
                .AddParameter(_acceptedContentType, jsonBody, ParameterType.RequestBody);
            
            restRequest.AddHeader("Accept", _accept);
            restRequest.AddHeader("Cookie", token);

            return await _client.ExecuteAsync<W>(restRequest);
        }

        public async Task<RestResponse> ExecuteAsync(RestRequest request)
        {
            return await _client.ExecuteAsync(request);
        }
    }
}