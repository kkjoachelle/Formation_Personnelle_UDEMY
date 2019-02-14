using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type__conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit type conversion
            byte a = 1;
            int b = a;
            Console.WriteLine("implicit type conversion "+b);
            Console.WriteLine("--------     --------");

            //explicit type conversion
            int a1 = 1;
            byte b1 = (byte)a1;
            Console.WriteLine("explicit type conversion " + b1);
            Console.WriteLine("--------     --------");

            //non compatible type 
            string s = "12345" +
                "o";
            int i = Convert.ToInt32(s);
            Console.WriteLine("I :explicit type conversion " + i);
            Console.WriteLine("--------     --------");

            int j = int.Parse(s);
            Console.WriteLine("J :explicit type conversion " + j);
            Console.WriteLine("--------     --------");

            //try
            //{
            //    int res = 12;
            //    int re = (int)res;
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Source " + ex.Source);
            //    Console.WriteLine("Message " + ex.Message);
            //}
            Console.ReadKey();
        }
    }
}
