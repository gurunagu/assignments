using System;
using System.Threading;

namespace OutParameter
{
    public class Program
    {
        public static void Main()
        {
            int i = 101;
            Console.WriteLine("\ni value in main:" + i);
            Thread t1 = new Thread(() => OutMethod(out i));
            t1.Start();
            //main thread sleep for 50ms
            Thread.Sleep(50);
            Console.WriteLine("\nin OutMethod after init:" + i);
            Console.ReadLine();
        }
        /// <summary>
        /// method containing an out Parameter
        /// </summary>
        /// <param name="j">out parameter</param>
        public static void OutMethod(out int j)
        {
            //OutMethod thread sleep for 100ms 
            Thread.Sleep(100);
            j = 62;
        }
    }
}