using System.Net;
using NUnit.Framework;
using RestfulBooker.Helpers;
using RestfulBooker.Models.CreateToken.Response;
using RestfulBooker.Services;
using RestSharp;

namespace RestfulBooker.Tests
{
    public class CreateTokenTests
    {
        [Test]
        public void SuccessfulCreateToken()
        {
            CreateTokenService service = new CreateTokenService(ConfigHelper.WEB_API_URL);
            
            RestResponse<CreateTokenResponse> createTokenResponse = service.CreateToken(Constants.ValidUsername, Constants.ValidPassword);
            
            Assert.That(createTokenResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(createTokenResponse.StatusDescription, Is.EqualTo(Constants.OkStatus));
            Assert.That(createTokenResponse.Data.Token, Is.Not.Empty);
        }
        
        [Test]
        public void CreateTokenWithoutUsername()
        {
            CreateTokenService service = new CreateTokenService(ConfigHelper.WEB_API_URL);
            RestResponse<CreateTokenErrorResponse> createTokenResponse = service.CreateTokenError("", Constants.ValidPassword);
            
            Assert.That(createTokenResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(createTokenResponse.Data.Reason, Is.EqualTo(Constants.BadCredentials));
        }
        
        [Test]
        public void CreateTokenWithoutPassword()
        {
            CreateTokenService service = new CreateTokenService(ConfigHelper.WEB_API_URL);
            RestResponse<CreateTokenErrorResponse> createTokenResponse = service.CreateTokenError(Constants.ValidUsername, "");
            
            Assert.That(createTokenResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(createTokenResponse.Data.Reason, Is.EqualTo(Constants.BadCredentials));
        }
        
        [Test]
        public void CreateTokenWithoutUsernameAndPassword()
        {
            CreateTokenService service = new CreateTokenService(ConfigHelper.WEB_API_URL);
            RestResponse<CreateTokenErrorResponse> createTokenResponse = service.CreateTokenError("", "");
            
            Assert.That(createTokenResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(createTokenResponse.Data.Reason, Is.EqualTo(Constants.BadCredentials));
        }
        
        [Test]
        public void CreateTokenWrongUsername()
        {
            CreateTokenService service = new CreateTokenService(ConfigHelper.WEB_API_URL);
            RestResponse<CreateTokenErrorResponse> createTokenResponse = service.CreateTokenError(Constants.WrongUsername, Constants.ValidPassword);
            
            Assert.That(createTokenResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(createTokenResponse.Data.Reason, Is.EqualTo(Constants.BadCredentials));
        }
        
        [Test]
        public void CreateTokenWrongPassword()
        {
            CreateTokenService service = new CreateTokenService(ConfigHelper.WEB_API_URL);
            RestResponse<CreateTokenErrorResponse> createTokenResponse = service.CreateTokenError(Constants.ValidUsername, Constants.WrongPassword);
            
            Assert.That(createTokenResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(createTokenResponse.Data.Reason, Is.EqualTo(Constants.BadCredentials));
        }
        
        [Test]
        public void CreateTokenWrongUsernameAndPassword()
        {
            CreateTokenService service = new CreateTokenService(ConfigHelper.WEB_API_URL);
            RestResponse<CreateTokenErrorResponse> createTokenResponse = service.CreateTokenError(Constants.WrongUsername, Constants.WrongPassword);
            
            Assert.That(createTokenResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(createTokenResponse.Data.Reason, Is.EqualTo(Constants.BadCredentials));
        }
    }
}