using DomainLayer.Models;
using DataLayer;

namespace BusinessLayer
{
    public class AuthenticationBusiness
    {
        AuthenticationData _authenticationData;

        public AuthenticationBusiness()
        {
            _authenticationData = new AuthenticationData();
        }

        /// <summary>
        /// Checks the login credintals
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns>string</returns>
        public string ValidateLogin(LoginModel loginModel)
        {
            return _authenticationData.ValidateLogin(loginModel);
        }

        /// <summary>
        /// user registration
        /// </summary>
        /// <param name="registrationModel"></param>
        /// <returns>string</returns>
        public string Register(RegistrationModel registrationModel)
        {
            return _authenticationData.Register(registrationModel);
        }
    }
}