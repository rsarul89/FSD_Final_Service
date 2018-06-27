
namespace SkillTracker.WebApi.Models
{
    public class LoginResponse
    {
        public LoginResponse()
        {

            this.Token = "";
            this.UserName = "";
        }

        public string Token { get; set; }
        public string UserName { get; set; }
        public int UserID { get; set; }

    }
}