using System.Net;
using System.Net.Http;
using System.Web.Http;
using SkillTracker.Common.Exception;
using SkillTracker.Entities;
using SkillTracker.Services;
using SkillTracker.WebApi.Models;

namespace SkillTracker.WebApi.Controllers
{
    [RoutePrefix("api/auth")]
    public class AuthenticationController : BaseAPIController
    {
        private IUserService _userService;
        private ILogManager _logManager;
        public AuthenticationController(IUserService userService, ILogManager logManager)
        {
            _userService = userService;
            _logManager = logManager;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public HttpResponseMessage Authenticate([FromBody] LoginRequest login)
        {
            var loginResponse = new LoginResponse { };
            LoginRequest loginrequest = new LoginRequest { };
            User usr = new User();

            bool isUsernamePasswordValid = false;

            if (login != null)
            {
                loginrequest.UserName = login.UserName.ToLower();
                loginrequest.Password = login.Password;
                usr = CheckUser(login.UserName, login.Password);
                if (usr != null)
                    isUsernamePasswordValid = true;
            }

            // if credentials are valid
            if (isUsernamePasswordValid)
            {
                string token = JwtManager.GenerateToken(loginrequest.UserName);
                //return the token
                loginResponse.Token = token;
                loginResponse.UserName = loginrequest.UserName;
                loginResponse.UserID = usr.user_id;
                return ToJson(loginResponse);
            }
            else
            {
                // if credentials are not valid send unauthorized status code in response
                throw new HttpResponseException(HttpStatusCode.Unauthorized);
            }
        }
        private User CheckUser(string username, string password)
        {
            var user = _userService.GetUser(username, password);
            return user;
        }
    }
}
