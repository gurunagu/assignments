using DomainLayer.Enums;
using DomainLayer.Models;
using System.Collections.Generic;
using System.Linq;
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
            SqlDataReader reader = null ;
            connect.Open();
            switch (role)
            {
                case UserChoiceEnum.Student :
                    {
                        string sqlQuery = "SELECT * FROM EMPLOYEE WHERE IsStudent = 'yes' ;";
                        SqlCommand command = new SqlCommand(sqlQuery, connect);
                         reader = command.ExecuteReader();
                        break;
                    }

                case UserChoiceEnum.Other:
                    {
                        string sqlQuery = "SELECT * FROM EMPLOYEE WHERE IsStudent = 'no';";
                        SqlCommand command = new SqlCommand(sqlQuery, connect);
                         reader = command.ExecuteReader();
                        break;
                    }

                case UserChoiceEnum.All:
                    {
                        string sqlQuery = "SELECT * FROM EMPLOYEE;";
                        SqlCommand command = new SqlCommand(sqlQuery, connect);
                         reader = command.ExecuteReader();                       
                        break;
                    }        
            }
            return reader;

        }
    }
}
