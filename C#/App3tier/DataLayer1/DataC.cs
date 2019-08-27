using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer1
{
    public class DataC
    {
        public static string st = "Data Source=ggku4mpc62;Initial Catalog=Gurunag;Integrated Security=True";
        private SqlConnection con = new SqlConnection(st);

        public void Insert(string id1,string name1)
        {
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                String com = "INSERT INTO EmpData(no,name) values (" + int.Parse(id1) + ",'" + name1 + "')";
                SqlCommand cmd = new SqlCommand(com, con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        public void Delete(string id1)
        {
            SqlConnection con = new SqlConnection(st);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                String com = "DELETE FROM EmpData WHERE (no = " + int.Parse(id1) + ")";
                SqlCommand cmd = new SqlCommand(com, con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        public string[] GetNames()
        {
            int c = 0;
            con.Open();           
            string[] res=new string[1000];
            SqlCommand cmd = new SqlCommand("select * from EmpData",con);
            SqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                res[c++] = read.GetString(1);
            }
            con.Close();

            return res;
        }
        public int[] GetNo()
        {
            int c = 0;
            con.Open();
            int[] res = new int[1000];
            SqlCommand cmd = new SqlCommand("select * from EmpData", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                res[c++] = read.GetInt32(0);
            }
            con.Close();
            return res;
        }
    }
}
