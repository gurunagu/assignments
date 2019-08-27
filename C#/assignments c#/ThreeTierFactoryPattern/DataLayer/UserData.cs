using DomainLayer.Enum;
using System.Data.SqlClient;
using DomainLayer;

namespace DataLayer
{
    public class UserData
    {
        /// <summary>
        /// Display the Data based on the enumeration selected by the user
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public SqlDataReader GetUserDetails(UserChoiceEnum role)
        {
            SqlConnection connect = new SqlConnection(StringLiterals.ConnectionString);
            SqlDataReader reader = null;
            connect.Open();

            switch (role)
            {
                case UserChoiceEnum.Student:
                    {
                        SqlCommand command = new SqlCommand(StringLiterals.SqlQueryYes, connect);
                        reader = command.ExecuteReader();
                        break;
                    }

                case UserChoiceEnum.Other:
                    {
                        SqlCommand command = new SqlCommand(StringLiterals.SqlQueryNo, connect);
                        reader = command.ExecuteReader();
                        break;
                    }

                case UserChoiceEnum.All:
                    {
                        SqlCommand command = new SqlCommand(StringLiterals.SqlQueryAll, connect);
                        reader = command.ExecuteReader();
                        break;
                    }
            }
            return reader;

        }
    }
}
