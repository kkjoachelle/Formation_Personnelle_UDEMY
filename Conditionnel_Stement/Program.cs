using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionnel_Stement
{
    partial class Program
    {
        static void Main(string[] args)
        {

            bool result = true;
            float Price;
            if (result)
                Price = 19.95f;
            else Price = 29.95f;

            Console.WriteLine(Price);
            Console.WriteLine("----------------------------------");
            float price1 = (result) ? 19.95f : 29.95f;
            Console.WriteLine(price1);
            Console.WriteLine("----------------------------------");
            var enumVal = Season.Automn;
            switch (enumVal)
            {
                case Season.Automn:
                Console.WriteLine("HI Automn ");
                break;

                case Season.Spring:
                Console.WriteLine("HI Spring");
                break;

                case Season.Summer:
                Console.WriteLine("HI Summer");
                break;

                case Season.Winter:
                Console.WriteLine("HI  Winter");
                break;

            }
            Console.ReadKey();
        }
}
}
