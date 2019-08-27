using DomainLayer.Enums;
using DataLayer;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class UserBusiness
    {
        UserData _userData;
        public UserBusiness()
        {
            _userData = new UserData();
        }

        /// <summary>
        /// method to get user details
        /// </summary>
        /// <param name="role">user choice enumeration</param>
        /// <returns></returns>
        public SqlDataReader GetUserDetails(UserChoiceEnum role)
        {
            return _userData.GetUserDetails(role);
        }
    }
}
