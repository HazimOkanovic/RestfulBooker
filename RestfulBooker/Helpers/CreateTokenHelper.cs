using RestfulBooker.Models.CreateToken.Response;
using RestfulBooker.Services;
using RestSharp;

namespace RestfulBooker.Helpers
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