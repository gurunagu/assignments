using System;
using System.Data.SqlClient;

namespace ConApp
{
    class Program
    {
 
        public static void Main(string[] args)
        {
            EmployeePortal _employeePortal = new EmployeePortal();
            _employeePortal.UserControl();
            Console.ReadLine();
        }
    }
}
