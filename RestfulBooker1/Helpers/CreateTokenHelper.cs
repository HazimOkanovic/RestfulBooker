using RestfulBooker1.Models.CreateToken.Response;
using RestfulBooker1.Services;
using RestSharp;

namespace RestfulBooker1.Helpers
{
    public class CreateTokenHelper
    {
        public static string Token { get; set; }
        
        public string CreateToken()
        {
            CreateTokenService service = new CreateTokenService(ConfigHelper.WEB_API_URL);
            
            RestResponse<CreateTokenResponse> createTokenResponse = service.CreateToken(Constants.ValidUsername, Constants.ValidPassword);

            var token = createTokenResponse.Data.Token;

            Token = token;

            return token;
        }
    }
}