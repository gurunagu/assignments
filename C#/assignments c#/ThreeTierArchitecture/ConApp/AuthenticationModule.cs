using BusinessLayer;
using DomainLayer.Models;

namespace ConApp
{
    class AuthenticationModule
    {
        AuthenticationBusiness _authenticationBusiness = new AuthenticationBusiness();
        /// <summary>
        /// Login method
        /// </summary>
        /// <param name="loginModel">object of LoginModel</param>
        /// <returns>valid or invalid login</returns>
        internal string Login(LoginModel loginModel)
        {
            
            return _authenticationBusiness.ValidateLogin(loginModel);
        }
        /// <summary>
        /// REgistration
        /// </summary>
        /// <param name="registrationModel">object of RegistrationModel</param>
        /// <returns>SuccessFully registered or not</returns>
        internal string  Register(RegistrationModel registrationModel)
        {
            return _authenticationBusiness.Register(registrationModel);
        }
    }
}
