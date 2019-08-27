using BusinessLayer;
using DomainLayer.Enums;
using System.Data.SqlClient;

namespace ConApp
{
    class UserModule
    {
        internal static UserBusiness _userBusiness ;
        public UserModule()
        {
            _userBusiness = new UserBusiness();
        }
        /// <summary>
        /// GEts the details
        /// </summary>
        /// <param name="role">Enumeration</param>
        /// <returns>data returned in form of sqlDataReader</returns>
        internal SqlDataReader GetUserDetails(UserChoiceEnum role)
        {           
            return _userBusiness.GetUserDetails(role);
        }
    }
}
