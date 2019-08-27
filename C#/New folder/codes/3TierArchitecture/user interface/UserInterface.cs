using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bussiness_layer;

namespace user_interface
{
    class UserInterface
    {
        static void Main(string[] args)
        {
            BussinessLayer firstObject = new BussinessLayer();
            firstObject.UserControl();
            Console.ReadLine();
        }
    }
}
