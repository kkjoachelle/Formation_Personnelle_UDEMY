using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] numbers = new int[] { 42, 11, 12, 13, 14, 15, 16, 17, 18, 19, 10 };
            int[] numbers = new int[10];
            numbers[0] = 42;
            numbers[1] = 11;
            numbers[2] = 12;
            numbers[3] = 13;
            numbers[4] = 14;
            // Affichage des elements du tableau
            foreach (var item in numbers)
                Console.Write(" "+item);
            Console.WriteLine();
            Console.WriteLine("-------------------");
            for (int i = 0; i < numbers.Length; i++)
                Console.Write(" " + numbers[i]);

            Console.ReadKey();
        }
    }
}
