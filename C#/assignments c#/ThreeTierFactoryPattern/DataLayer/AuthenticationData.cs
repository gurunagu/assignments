using DomainLayer.Models;
using System.Data.SqlClient;
using DomainLayer;

namespace DataLayer
{
    public class AuthenticationData : IRegistrationModel
    {
        public string EmailId { get; }
        public string Password { get;  }
        public string ConfirmPassword { get; }
        public string FirstName { get; }
        public string LastName { get;  }
        public string IsStudent { get;  }

        public AuthenticationData(string emailId, string password)
        {
             EmailId = emailId;
             Password = password;
        }

        public AuthenticationData(string emailId, string password, string conformPassword, string firstName, string lastName, string isStudent)
        {
            EmailId = emailId;
            Password = password;
            ConfirmPassword = conformPassword;
            FirstName = firstName;
            LastName = lastName;
            IsStudent = isStudent;
        }

        /// <summary>
        /// validates the login credintals
        /// </summary>
        /// <returns></returns>
        public string ValidateLogin()
        {
            SqlConnection connect = new SqlConnection(StringLiterals.ConnectionString);
            connect.Open();
            string sqlQuery = string.Format("SELECT * FROM EMPLOYEE WHERE EmailId = '{0}' AND Password ='{1}';",EmailId,Password);
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
        /// <returns></returns>
        public string Register()
        {
            SqlConnection connect = new SqlConnection(StringLiterals.ConnectionString);

            try
            {
                connect.Open();
                string sqlQuery = string.Format("INSERT INTO EMPLOYEE VALUES ('{0}','{1}','{2}','{3}','{4}');", EmailId, Password, FirstName, LastName, IsStudent);
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
                    return StringLiterals.Exception;
;
                }
            }
        }
    }
}
