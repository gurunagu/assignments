using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Layer;

namespace Bussiness_layer
{
    public class BussinessLayer
    {
        /// <summary>
        /// stores the data given by the user
        /// </summary>
        /// <param name="data">local variable</param>
        public void StoreData(double data)
        {
            DataLayer.StoreUserData = DataLayer.StoreUserData + " " + data;
        }
        /// <summary>
        /// Display the stored data
        /// </summary>
        /// <returns>data</returns>
        public string DisplayData()
        {
            return DataLayer.StoreUserData;
        }
        /// <summary>
        /// searches the data based on user value
        /// </summary>
        /// <param name="Value">local variable</param>
        /// <returns>boolean value</returns>
        public bool Search(double Value)
        {
            bool checkValue = DataLayer.StoreUserData.Contains(Value.ToString());
            return checkValue;
        }
        /// <summary>
        /// user controller
        /// </summary>
        public void UserControl()
        {
            int option = 0;
            double data, value;
            while (option != 5)
            {
                Console.WriteLine("\nenter option\n1)Enter Data\n2)Display Stored Data\n3)Search Data\n4)delete\n5)exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("enter data to store");
                            data = double.Parse(Console.ReadLine());
                            StoreData(data);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("The data stored in memory is:" + DisplayData());
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter data to search");
                            value = double.Parse(Console.ReadLine());
                            if (Search(value))
                            {
                                Console.WriteLine($"'Data {value} is Present'");
                            }
                            else
                            {
                                Console.WriteLine($"'Data {value} is not Present'");
                            }
                            Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("enter the value to be deleted");
                            value = double.Parse(Console.ReadLine());
                            if(Search(value))
                            {
                                string s = " " + value.ToString();
                                DataLayer.StoreUserData = DataLayer.StoreUserData.Replace(s, "");
                                Console.WriteLine($"'Data {value} is deleted'");
                            }
                            else
                            {
                                Console.WriteLine($"'Data {value} is not Present'");
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Press ENTER to exit...");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid!! Press ENTER to Try again...");
                            Console.ReadLine();
                            break;
                        }
                }
            }
        }
    }
}
