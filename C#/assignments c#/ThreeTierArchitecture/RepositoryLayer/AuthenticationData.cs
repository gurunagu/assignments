using DomainLayer.Models;
using System.Linq;
using System.Data.SqlClient;
using DomainLayer;
using System.Data;

namespace DataLayer
{
    public class AuthenticationData
    {
        /// <summary>
        /// validates the login credintals
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public string ValidateLogin(LoginModel loginModel)
        {
            SqlConnection connect = new SqlConnection(StringLiterals.ConnectionString);
            connect.Open();


            string sqlQuery = "SELECT * FROM EMPLOYEE WHERE EmailId = '" + loginModel.EmailId + "' AND Password ='" + loginModel.Password + "';";
            SqlCommand command = new SqlCommand(sqlQuery, connect);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                connect.Close();
                return StringLiterals.LoginSuccessful;
            }
            else
            {
                connect.Close();
                return StringLiterals.LoginUnsuccessful;
            }
        }

        /// <summary>
        /// registers a user
        /// </summary>
        /// <param name="registrationModel"></param>
        /// <returns></returns>
        public string Register(RegistrationModel registrationModel)
        {

            SqlConnection connect = new SqlConnection(StringLiterals.ConnectionString);
            try
            {
                connect.Open();
                string sqlQuery = "INSERT INTO EMPLOYEE VALUES ('" + registrationModel.EmailId + "','" + registrationModel.Password + "','"
                    + registrationModel.FirstName + "','" + registrationModel.LastName + "','" + registrationModel.IsStudent + "');";
                SqlCommand command = new SqlCommand(sqlQuery, connect);
                command.ExecuteNonQuery();
                return StringLiterals.RegistrationSucces;
            }
            catch (SqlException Ex)
            {
                if (Ex.Number == 2627)
                {
                    return StringLiterals.AlreadyEmail;
                }
                else
                {
                    return "exception occured"
;                }
            } 
        }
    }
}
